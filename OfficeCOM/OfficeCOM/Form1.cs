using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MsWord = Microsoft.Office.Interop.Word;

namespace OfficeCOM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //创建文档的小节
        public static void createPart(MsWord.Application oWordApplic, MsWord.Document oDoc)
        {
            MsWord.Range curRange;
            object curTxt = null;
            int curSectionNum = 1;
            object missing = System.Reflection.Missing.Value;
            oDoc = oWordApplic.Documents.Add(ref missing, ref missing, ref missing, ref missing);
            oDoc.Activate();
            MessageBox.Show("生成文档小节");
            object section_nextPage = MsWord.WdBreakType.wdSectionBreakNextPage;
            object page_break = MsWord.WdBreakType.wdPageBreak;
            //添加四个分节符，共五个小节，小节的类型是下一页
            for (int si = 0; si < 4; si++)
            {
                oDoc.Paragraphs[1].Range.InsertParagraphAfter();
                oDoc.Paragraphs[1].Range.InsertBreak(ref section_nextPage);
            }

            curRange = oDoc.Sections[curSectionNum].Range.Paragraphs[1].Range;

            insertAbstract(curSectionNum, curRange, oWordApplic, oDoc, curTxt);
        }
        /*插入摘要文本并设置文本格式，从文件abstract.txt中读取文本内容作为摘要部分内容，
         * Word文档的内容都是具有格式的，读入的文本内容是Word的普通正文格式
         * 须重新设置文本格式与段落格式 
         */
        public static void insertAbstract(int curSectionNum, MsWord.Range curRange, MsWord.Application oWordApplic, MsWord.Document oDoc, object curTxt)
        {
            MessageBox.Show("插入摘要内容");
            # region 摘要部分
            curSectionNum = 1;
            // curRange = oDoc.Sections[curSectionNum].Range.Paragraphs[1].Range;
            curRange.Select();
            string one_str = null, key_word;
            //摘要的文本来自abstract.txt文本文件
            StreamReader file_abstract = new StreamReader("abstract.txt");
            oWordApplic.Options.Overtype = false;
            MsWord.Selection currentSelection = oWordApplic.Selection;
            if (currentSelection.Type == MsWord.WdSelectionType.wdSelectionNormal)
            {
                one_str = file_abstract.ReadLine();
                currentSelection.TypeText(one_str);
                currentSelection.TypeParagraph();
                currentSelection.TypeText("摘要");
                currentSelection.TypeParagraph();
                key_word = file_abstract.ReadLine();
                one_str = file_abstract.ReadLine();
                while (one_str != null)
                {
                    currentSelection.TypeText(one_str);
                    currentSelection.TypeParagraph();
                    one_str = file_abstract.ReadLine();

                }
                currentSelection.TypeText("关键字：");
                currentSelection.TypeText(key_word);
                currentSelection.TypeParagraph();
            }
            file_abstract.Close();
            //下面设置摘要文本的格式：
            //摘要的标题
            curRange = oDoc.Sections[curSectionNum].Range.Paragraphs[1].Range;
            curTxt = curRange.Paragraphs[1].Range.Text;
            curRange.Font.Name = "宋体";
            curRange.Font.Size = 22;
            curRange.Paragraphs[1].Alignment = MsWord.WdParagraphAlignment.wdAlignParagraphCenter;
            //摘要两个字
            curRange = oDoc.Sections[curSectionNum].Range.Paragraphs[2].Range;
            curRange.Select();
            curRange.Paragraphs[1].Alignment = MsWord.WdParagraphAlignment.wdAlignParagraphCenter;
            curRange.Font.Name = "黑体";
            curRange.Font.Size = 16;
            //摘要正文
            oDoc.Sections[curSectionNum].Range.Paragraphs[1].Alignment = MsWord.WdParagraphAlignment.wdAlignParagraphCenter;
            for (int i = 3; i < oDoc.Sections[curSectionNum].Range.Paragraphs.Count; i++)
            {
                curRange = oDoc.Sections[curSectionNum].Range.Paragraphs[i].Range;
                curTxt = curRange.Paragraphs[1].Range.Text;
                curRange.Select();
                curRange.Font.Name = "宋体";
                curRange.Font.Size = 12;
                oDoc.Sections[curSectionNum].Range.Paragraphs[i].LineSpacingRule = MsWord.WdLineSpacing.wdLineSpaceMultiple;
                //多倍行距，1.25倍，这里的浮点值是以point为单位的，不是行距倍数
                oDoc.Sections[curSectionNum].Range.Paragraphs[i].LineSpacing = 15f;
                oDoc.Sections[curSectionNum].Range.Paragraphs[i].IndentFirstLineCharWidth(2);
            }
            //设置关键字为黑体
            curRange = curRange.Paragraphs[curRange.Paragraphs.Count].Range;
            curTxt = curRange.Paragraphs[1].Range.Text;
            object range_start, range_end;
            range_start = curRange.Start;
            range_end = curRange.Start + 4;
            curRange = oDoc.Range(ref range_start, ref range_end);
            curTxt = curRange.Text;
            curRange.Select();
            curRange.Font.Bold = 1;
            #endregion 摘要部分

            insertDirectory(curSectionNum, curRange, oDoc, currentSelection, oWordApplic, one_str);

        }
        public static void insertDirectory(int curSectionNum, MsWord.Range curRange, MsWord.Document oDoc, MsWord.Selection currentSelection, MsWord.Application oWordApplic, string one_str)
        {
            MessageBox.Show("正在插入目录");
            #region 目录
            curSectionNum = 2;
            curRange = oDoc.Sections[curSectionNum].Range.Paragraphs[1].Range;
            curRange.Select();
            //插入目录时指定的参数
            object useheading_styles = true;
            object upperheading_level = 1;
            object lowerheading_level = 3;
            object usseelds = 1;
            object tableid = 1;
            object RightAlignPageNumbers = true;
            object IncludePageNumbers = true;
            currentSelection = oWordApplic.Selection;
            currentSelection.TypeText("目录");
            currentSelection.TypeParagraph();
            currentSelection.Select();
            curRange = oDoc.Sections[curSectionNum].Range.Paragraphs[2].Range;
            //插入的表格会代替当前range
            //range为非折叠时，TableOfContents会代替range，引起小节数减少
            curRange.Collapse();
            object missing = System.Reflection.Missing.Value;
            oDoc.TablesOfContents.Add(curRange, ref useheading_styles, ref upperheading_level, ref lowerheading_level, ref usseelds, ref tableid, ref RightAlignPageNumbers, ref IncludePageNumbers, ref missing, ref missing, ref missing, ref missing);
            oDoc.Sections[curSectionNum].Range.Paragraphs[1].Alignment = MsWord.WdParagraphAlignment.wdAlignParagraphCenter;
            oDoc.Sections[curSectionNum].Range.Paragraphs[1].Range.Font.Bold = 1;
            oDoc.Sections[curSectionNum].Range.Paragraphs[1].Range.Font.Name = "黑体";
            oDoc.Sections[curSectionNum].Range.Paragraphs[1].Range.Font.Size = 16;

            #endregion 目录
            insertContext(curSectionNum, curRange, oDoc, currentSelection, oWordApplic);
        }
        //插入第一章正文并设置正文格式
        public static void insertContext(int curSectionNum, MsWord.Range curRange, MsWord.Document oDoc, MsWord.Selection currentSelection, MsWord.Application oWordApplic)
        {
            #region 第一章
            curSectionNum = 3;
            oDoc.Sections[curSectionNum].Range.Paragraphs[1].Range.Select();
            curRange = oDoc.Sections[curSectionNum].Range.Paragraphs[1].Range;
            MessageBox.Show("正在设置标题样式");
            object wdFontSizeIndex = 14;
            //此序号是在Word中的编号是格式->显示格式->样式和格式->显示所有样式的序号
            //14是标题一，一级标题：三号黑体
            //oWordApplic.ActiveDocument.Styles.get_Item(ref wdFontSizeIndex).ParagraphFormat.Alignment =
            //    MsWord.WdParagraphAlignment.wdAlignParagraphCenter;
            oWordApplic.ActiveDocument.Styles.get_Item(ref wdFontSizeIndex).Font.Name = "黑体";
            oWordApplic.ActiveDocument.Styles.get_Item(ref wdFontSizeIndex).Font.Size = 16f;//三号
            wdFontSizeIndex = 15;  //15是标题二，二级标题：小三号黑体
            oWordApplic.ActiveDocument.Styles.get_Item(ref wdFontSizeIndex).Font.Name = "黑体";
            oWordApplic.ActiveDocument.Styles.get_Item(ref wdFontSizeIndex).Font.Size = 15f;//小三
            //用指定的标题来设定文本格式
            object style1 = MsWord.WdBuiltinStyle.wdStyleHeading1;
            object style2 = MsWord.WdBuiltinStyle.wdStyleHeading2;
            oDoc.Sections[curSectionNum].Range.Select();
            currentSelection = oWordApplic.Selection;
            //读入第一章文本信息
            StreamReader file_content = new StreamReader("context.txt");
            String one_str = file_content.ReadLine();
            currentSelection.TypeText(one_str);
            currentSelection.TypeParagraph();
            one_str = file_content.ReadLine();
            currentSelection.TypeText(one_str);
            currentSelection.TypeParagraph();
            one_str = file_content.ReadLine();
            while (one_str != null)
            {
                currentSelection.TypeText(one_str);
                currentSelection.TypeParagraph();
                one_str = file_content.ReadLine();
            }
            file_content.Close();
            //段落的对齐方式
            curRange = oDoc.Sections[curSectionNum].Range.Paragraphs[1].Range;
            curRange.set_Style(ref style1);
            oDoc.Sections[curSectionNum].Range.Paragraphs[1].Alignment = MsWord.WdParagraphAlignment.wdAlignParagraphCenter;
            curRange = oDoc.Sections[curSectionNum].Range.Paragraphs[2].Range;
            curRange.set_Style(ref style2);
            //第一章正文文本格式
            for (int i = 3; i < oDoc.Sections[curSectionNum].Range.Paragraphs.Count; i++)
            {
                curRange = oDoc.Sections[curSectionNum].Range.Paragraphs[i].Range;
                curRange.Select();
                curRange.Font.Name = "宋体";
                curRange.Font.Size = 12;
                oDoc.Sections[curSectionNum].Range.Paragraphs[i].LineSpacingRule = MsWord.WdLineSpacing.wdLineSpaceMultiple;
                //多倍行距，1.25倍，这里的浮点值是以point为单位的，不是行距的倍数
                oDoc.Sections[curSectionNum].Range.Paragraphs[i].LineSpacing = 15f;
                oDoc.Sections[curSectionNum].Range.Paragraphs[i].IndentFirstLineCharWidth(2);

            }
            #endregion 第一章
            insertExel(curSectionNum, curRange, oDoc, currentSelection, oWordApplic);
        }
        //插入表格并设置表格格式
        public static void insertExel(int curSectionNum, MsWord.Range curRange, MsWord.Document oDoc, MsWord.Selection currentSelection, MsWord.Application oWordApplic)
        {
            MessageBox.Show("正在插入第2章内容");
            #region 第二章表格
            curSectionNum = 4;
            oDoc.Sections[curSectionNum].Range.Select();
            curRange = oDoc.Sections[curSectionNum].Range.Paragraphs[1].Range;
            currentSelection = oWordApplic.Selection;
            currentSelection.TypeText("2 表格");
            currentSelection.TypeParagraph();
            currentSelection.TypeText("表格示例");
            currentSelection.TypeParagraph();
            currentSelection.TypeParagraph();
            curRange = oDoc.Sections[curSectionNum].Range.Paragraphs[3].Range;
            oDoc.Sections[curSectionNum].Range.Paragraphs[3].Range.Select();
            currentSelection = oWordApplic.Selection;
            MsWord.Table oTable;
            object missing = System.Reflection.Missing.Value;
            oTable = curRange.Tables.Add(curRange, 5, 3, ref missing, ref missing);
            oTable.Range.ParagraphFormat.Alignment = MsWord.WdParagraphAlignment.wdAlignParagraphCenter;
            oTable.Range.Font.Name = "宋体";
            oTable.Range.Font.Size = 16;
            oTable.Range.Cells.VerticalAlignment = MsWord.WdCellVerticalAlignment.wdCellAlignVerticalCenter;
            oTable.Range.Rows.Alignment = MsWord.WdRowAlignment.wdAlignRowCenter;
            oTable.Columns[1].Width = 80;
            oTable.Columns[2].Width = 180;
            oTable.Columns[3].Width = 80;
            oTable.Cell(1, 1).Range.Text = "字段";
            oTable.Cell(1, 2).Range.Text = "描述";
            oTable.Cell(1, 3).Range.Text = "数据类型";
            oTable.Cell(2, 1).Range.Text = "ProductID";
            oTable.Cell(2, 2).Range.Text = "产品标识";
            oTable.Cell(2, 3).Range.Text = "字符串";
            oTable.Borders.InsideLineStyle = MsWord.WdLineStyle.wdLineStyleSingle;
            oTable.Borders.OutsideLineStyle = MsWord.WdLineStyle.wdLineStyleSingle;
            curRange = oDoc.Sections[curSectionNum].Range.Paragraphs[1].Range;
            curRange.set_Style(MsWord.WdBuiltinStyle.wdStyleHeading1);
            curRange.ParagraphFormat.Alignment = MsWord.WdParagraphAlignment.wdAlignParagraphCenter;

            #endregion 第二章
            insertImage(curSectionNum, curRange, oDoc, currentSelection, oWordApplic);
        }
        //插入图片
        public static void insertImage(int curSectionNum, MsWord.Range curRange, MsWord.Document oDoc, MsWord.Selection currentSelection, MsWord.Application oWordApplic)
        {
            MessageBox.Show("准备插入第三章内容");
            #region 第三章图片
            curSectionNum = 5;
            oDoc.Sections[curSectionNum].Range.Paragraphs[1].Range.Select();
            curRange = oDoc.Sections[curSectionNum].Range.Paragraphs[1].Range;
            currentSelection = oWordApplic.Selection;
            currentSelection.TypeText("3 图片");
            currentSelection.TypeParagraph();
            currentSelection.TypeText("图片示例");
            currentSelection.TypeParagraph();
            object missing = System.Reflection.Missing.Value;
            currentSelection.InlineShapes.AddPicture(@"C:\Users\dzy\Desktop\大三上\Windows\WindowHomework\OfficeCOM\OfficeCOM\bin\Debug\whu.png", ref missing, ref missing, ref missing);
            curRange = oDoc.Sections[curSectionNum].Range.Paragraphs[1].Range;
            curRange.set_Style(MsWord.WdBuiltinStyle.wdStyleHeading1);
            curRange.ParagraphFormat.Alignment = MsWord.WdParagraphAlignment.wdAlignParagraphCenter;
            #endregion 第三章
            setPage(curSectionNum, curRange, oDoc, currentSelection, oWordApplic);
        }
        public static void setPage(int curSectionNum, MsWord.Range curRange, MsWord.Document oDoc, MsWord.Selection currentSelection, MsWord.Application oWordApplic)
        {
            MessageBox.Show("准备设置第一节摘要页眉内容");
            //设置页脚section1 摘要
            curSectionNum = 1;
            oDoc.Sections[curSectionNum].Range.Select();
            //进入页脚视图
            oWordApplic.ActiveWindow.ActivePane.View.SeekView = MsWord.WdSeekView.wdSeekCurrentPageFooter;
            oDoc.Sections[curSectionNum].Headers[MsWord.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range.Borders[MsWord.WdBorderType.wdBorderBottom].LineStyle = MsWord.WdLineStyle.wdLineStyleNone;
            oWordApplic.Selection.HeaderFooter.PageNumbers.RestartNumberingAtSection = true;
            oWordApplic.Selection.HeaderFooter.PageNumbers.NumberStyle = MsWord.WdPageNumberStyle.wdPageNumberStyleUppercaseRoman;
            oWordApplic.Selection.HeaderFooter.PageNumbers.StartingNumber = 1;
            oWordApplic.ActiveWindow.ActivePane.View.SeekView = MsWord.WdSeekView.wdSeekMainDocument;
            Console.WriteLine("正在设置第2节目录页眉内容");
            curSectionNum = 2;
            oDoc.Sections[curSectionNum].Range.Select();
            //进人页脚视图
            oWordApplic.ActiveWindow.ActivePane.View.SeekView = MsWord.WdSeekView.wdSeekCurrentPageFooter;
            oDoc.Sections[curSectionNum].Headers[MsWord.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range.Borders[MsWord.WdBorderType.wdBorderBottom].LineStyle = MsWord.WdLineStyle.wdLineStyleNone;
            oWordApplic.Selection.HeaderFooter.PageNumbers.RestartNumberingAtSection = false;
            oWordApplic.Selection.HeaderFooter.PageNumbers.NumberStyle = MsWord.WdPageNumberStyle.wdPageNumberStyleUppercaseRoman;
            oWordApplic.ActiveWindow.ActivePane.View.SeekView = MsWord.WdSeekView.wdSeekMainDocument;
            //第1章页眉页码设置
            curSectionNum = 3;
            oDoc.Sections[curSectionNum].Range.Select();
            //切换人页脚视图
            oWordApplic.ActiveWindow.ActivePane.View.SeekView = MsWord.WdSeekView.wdSeekCurrentPageFooter;
            currentSelection = oWordApplic.Selection;
            curRange = currentSelection.Range;
            oWordApplic.Selection.HeaderFooter.PageNumbers.RestartNumberingAtSection = true;//页码格式为阿拉伯数字
            oWordApplic.Selection.HeaderFooter.PageNumbers.NumberStyle = MsWord.WdPageNumberStyle.wdPageNumberStyleArabic;
            oWordApplic.Selection.HeaderFooter.PageNumbers.StartingNumber = 1;
            object fieldPage = MsWord.WdFieldType.wdFieldPage;
            object missing = System.Reflection.Missing.Value;
            oWordApplic.Selection.Fields.Add(oWordApplic.Selection.Range, ref fieldPage, ref missing, ref missing);

            //居中对齐

            oWordApplic.Selection.ParagraphFormat.Alignment = MsWord.WdParagraphAlignment.wdAlignParagraphCenter;

            //本小节不链接到上一节 
            oDoc.Sections[curSectionNum].Headers[Microsoft.Office.Interop.Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].LinkToPrevious = false;
            //切换入正文视图
            oWordApplic.ActiveWindow.ActivePane.View.SeekView = MsWord.WdSeekView.wdSeekMainDocument;
            save(curSectionNum, curRange, oDoc, currentSelection, oWordApplic);
        }
        //文档保存
        public static void save(int curSectionNum, MsWord.Range curRange, MsWord.Document oDoc, MsWord.Selection currentSelection, MsWord.Application oWordApplic)
        {
            MessageBox.Show("更新目录");
            oDoc.Fields[1].Update();
            #region 保存文档
            MessageBox.Show("保存word文档");
            object fileName;
            fileName = Directory.GetCurrentDirectory() + @"\content.doc";
            oDoc.SaveAs2(ref fileName);
            oDoc.Close();
            MessageBox.Show("释放COM资源");
            System.Runtime.InteropServices.Marshal.ReleaseComObject(oDoc);
            oDoc = null;
            oWordApplic.Quit();
            System.Runtime.InteropServices.Marshal.ReleaseComObject(oWordApplic);
            oWordApplic = null;
            #endregion 保存文档
        }

        private void button1_Click(object sender, EventArgs e)
        {

            MsWord.Application oWordApplic;
            MsWord.Document oDoc = null;
            try
            {
                String doc_file_name = Directory.GetCurrentDirectory() + @"\content.doc";
                if (File.Exists(doc_file_name))
                {
                    File.Delete(doc_file_name);
                }
                oWordApplic = new MsWord.Application();
                object missing = System.Reflection.Missing.Value;
                createPart(oWordApplic, oDoc);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            finally
            {
                Console.WriteLine("正在结束word进程");
                System.Diagnostics.Process[] ALLproces = System.Diagnostics.Process.GetProcesses();
                for (int j = 0; j < ALLproces.Length; j++)
                {
                    string theProcName = ALLproces[j].ProcessName;
                    if (String.Compare(theProcName, "WINWORD") == 0)
                    {
                        if (ALLproces[j].Responding && !ALLproces[j].HasExited)
                        {
                            ALLproces[j].Kill();
                        }
                    }
                }
            }
        }
    }
}
