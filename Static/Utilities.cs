using System;
using System.Linq;
using System.Data;
using System.Data.Entity.Core.Objects;
using System.Data.SqlClient;
using System.Data.Entity.Core.EntityClient;
using ScoutingCodeRedo.Dynamic;

namespace ScoutingCodeRedo.Static
{
    public class Utilities
    {

        SeasonContext seasonframework = new SeasonContext();    //This is the context, meaning the entire database structure supporting this application.

        //Name: Log Match Event
        //Purpose: This code handles the saving of a Match Event when someone enters one and presses the left joystick button
        public void LogMatchEvent(String Scouter, String Event, String Team, int Match)
        {
            Activity activity_record = new Activity();

            activity_record.Time = DateTime.Now;
            activity_record.Match = Match;
            //activity_record.MatchEvent = Event;
            activity_record.Team = Team;
            activity_record.ScouterName = Scouter;
            activity_record.RecordType = "MatchEvent";
            seasonframework.ActivitySet.Add(activity_record);
            seasonframework.SaveChanges();
        }

        /*
        public void EntityToExcelSheet(string excelFilePath,
       string sheetName, IQueryable result, ObjectContext ctx)
        {
            Excel.Application oXL;
            Excel.Workbook oWB;
            Excel.Worksheet oSheet;
            Excel.Range oRange;
            try
            {
                //Start Excel and get Application object.
                oXL = new Excel.Application();

                //Set some properties
                oXL.Visible = true;
                oXL.DisplayAlerts = false;

                //Get a new workbook. 
                oWB = oXL.Workbooks.Add(Missing.Value);

                //Get the active sheet 
                oSheet = (Excel.Worksheet)oWB.ActiveSheet;
                oSheet.Name = sheetName;

                //Process the DataTable
                //BE SURE TO CHANGE THIS LINE TO USE *YOUR* DATATABLE 
                DataTable dt = EntityToDataTable(result, ctx);

                int rowCount = 1;
                foreach (DataRow dr in dt.Rows)
                {
                    rowCount += 1;
                    for (int i = 1; i < dt.Columns.Count + 1; i++)
                    {
                        //Add the header the first time through 
                        if (rowCount == 2)
                            oSheet.Cells[1, i] = dt.Columns[i - 1].ColumnName;
                        oSheet.Cells[rowCount, i] = dr[i - 1].ToString();
                    }
                }

                //Resize the columns 
                oRange = oSheet.Range[oSheet.Cells[1, 1], oSheet.Cells[rowCount, dt.Columns.Count]];
                oRange.Columns.AutoFit();

                //Save the sheet and close 
                oSheet = null;
                oRange = null;
                oWB.SaveAs(excelFilePath, Excel.XlFileFormat.xlWorkbookNormal, Missing.Value,
                  Missing.Value, Missing.Value, Missing.Value,
                  Excel.XlSaveAsAccessMode.xlExclusive, Missing.Value,
                  Missing.Value, Missing.Value, Missing.Value);
                oWB.Close(Missing.Value, Missing.Value, Missing.Value);
                oWB = null;
                oXL.Quit();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        */
        public DataTable EntityToDataTable(IQueryable result, ObjectContext ctx)
        {
            try
            {
                EntityConnection conn = ctx.Connection as EntityConnection;
                using (SqlConnection SQLCon = new SqlConnection(conn.StoreConnection.ConnectionString))
                {
                    ObjectQuery query = result as ObjectQuery;
                    using (SqlCommand Cmd = new SqlCommand(query.ToTraceString(), SQLCon))
                    {
                        foreach (var param in query.Parameters)
                        {
                            Cmd.Parameters.AddWithValue(param.Name, param.Value);
                        }
                        using (SqlDataAdapter da = new SqlDataAdapter(Cmd))
                        {
                            using (DataTable dt = new DataTable())
                            {
                                da.Fill(dt);
                                return dt;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
