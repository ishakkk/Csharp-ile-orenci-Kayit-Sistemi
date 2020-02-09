using System;
using System.Data;
using System.Windows.Forms;

namespace BilgisayarMuhendislikOzelKonular.Classes
{
    public static class Excel
    {
        public static void ExportToExcel(this DataTable tbl, string excelFilePath = null)
        {
            try
            {
                if (tbl == null || tbl.Columns.Count == 0)
                    throw new Exception("ExportToExcel : Tablonuz herhangi bir veri yok !\n");

                var excelApp = new Microsoft.Office.Interop.Excel.Application();
                excelApp.Workbooks.Add();

                Microsoft.Office.Interop.Excel._Worksheet workSheet = excelApp.ActiveSheet;

                for (var i = 0; i < tbl.Columns.Count; i++)
                {
                    workSheet.Cells[1, i + 1] = tbl.Columns[i].ColumnName;
                }

                for (var i = 0; i < tbl.Rows.Count; i++)
                {
                    for (var j = 0; j < tbl.Columns.Count; j++)
                    {
                        workSheet.Cells[i + 2, j + 1] = tbl.Rows[i][j];
                    }
                }

                if (!string.IsNullOrEmpty(excelFilePath))
                {
                    try
                    {
                        workSheet.SaveAs(excelFilePath);
                        excelApp.Quit();
                        MessageBox.Show("Excel dosyası kaydedildi.");
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("ExportToExcel: Excel dosyanız kaydedilemedi. Dosya yolunu kontrol edin.\n"
                                            + ex.Message);
                    }
                }
                else
                {
                    excelApp.Visible = true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("ExportToExcel: \n" + ex.Message);
            }
        }
    }
}
