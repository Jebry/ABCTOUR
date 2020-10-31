
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using System.Windows;

namespace FinalExam_BasharJebry
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "TourService_Bashar" in both code and config file together.
    public class TourService_Bashar : ITourAuthenticateUserService_Bashar, ITourDBOperationsService_Bashar
    {
       
        public string AuthenticateUser(UserInfo user)
        {
            ABCTourDB_BasharJebryEntities context = new ABCTourDB_BasharJebryEntities();
            string msg = string.Empty;
            var checkedUser = context.Users.Find(user.UserName);
            try
            {
                if (checkedUser != null)
                {


                    if (checkedUser.Password == user.Password)
                    {
                        msg = "Login Success";
                    }
                    else
                    {
                        msg = "Login Failed";
                    }
                }
                else
                {
                    msg = "Login Failed";
                }
                
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException ex)
            {
                MessageBox.Show(ex.Message);
            }

            return msg;

        }

      


        public string DeleteABus(DeleteABus bus)
        {
           
            ABCTourDB_BasharJebryEntities context = new ABCTourDB_BasharJebryEntities();
            
            string msg = string.Empty;
            try
            {
                var DeletedInfo = context.BusInfoes.Find(bus.BusId);
                context.BusInfoes.Remove(DeletedInfo);
                context.SaveChanges();
                msg = "Data deletion sucess!";
                SqlConnection conn;
                SqlCommand cmd;
                conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Resume\copy\copy\copy\copy\FinalExamProjectAndScreenShots-BasharJebry\FinalExam\FinalExam-BasharJebry\ABCTourDB_BasharJebry.mdf;Integrated Security=True");
                conn.Open();
                cmd = new SqlCommand("Delete from BusInfo where BusId=@Id", conn);
                cmd.Parameters.AddWithValue("@Id", bus.BusId);
                int result = cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException ex)
            {
                    msg = ex.Message;
                    msg = "Data deletion failed!";
            }
            return msg;
        }

        public string InsertABus(InsertABus bus)
        {
            ABCTourDB_BasharJebryEntities context = new ABCTourDB_BasharJebryEntities();

            string msg = string.Empty;

            BusInfo newInfo = new BusInfo()
                {
                    BusId = bus.BusId,
                    Make = bus.Make,
                    Model = bus.Model,
                    NoOfSeats = bus.NoOfSeats
                };
            try
            {
                context.BusInfoes.Add(newInfo);
                context.SaveChanges();
                SqlConnection conn;
                SqlCommand cmd;
                conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Resume\copy\copy\copy\copy\FinalExamProjectAndScreenShots-BasharJebry\FinalExam\FinalExam-BasharJebry\ABCTourDB_BasharJebry.mdf;Integrated Security=True");
                conn.Open();
                cmd = new SqlCommand("Insert into BusInfo values(@BusId, @Make, @Model,@NoOfSeat)", conn);
                cmd.Parameters.AddWithValue("@BusId", bus.BusId);
                cmd.Parameters.AddWithValue("@Make", bus.Make);
                cmd.Parameters.AddWithValue("@Model", bus.Model);
                cmd.Parameters.AddWithValue("@NoOfSeat", bus.NoOfSeats);
                int result = cmd.ExecuteNonQuery();
                conn.Close();
                msg = "Record inserted";
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException ex)
            {
                msg= ex.Message;
                msg = "Record NOT inserted";
                
            }
            return msg;
        }


        public string UpdateABus(UpdateABus bus)
        {
            ABCTourDB_BasharJebryEntities context = new ABCTourDB_BasharJebryEntities();


            string msg = string.Empty;
            BusInfo newInfo = new BusInfo();

            
            try
            {
                var updatedInfo = context.BusInfoes.Find(bus.BusId);
                updatedInfo.Make = bus.Make;
                updatedInfo.Model = bus.Model;
                updatedInfo.NoOfSeats = bus.NoOfSeats;
                context.SaveChanges();
                msg = "Record Updated!!";
                SqlConnection conn;
                SqlCommand cmd;
                conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Resume\copy\copy\copy\copy\FinalExamProjectAndScreenShots-BasharJebry\FinalExam\FinalExam-BasharJebry\ABCTourDB_BasharJebry.mdf;Integrated Security=True");
                conn.Open();
                cmd = new SqlCommand("Update BusInfo set Model=@Model, Make=@Make ,NoOfSeats=@NoOfSeats where BusId=@BusId", conn);
                cmd.Parameters.AddWithValue("@BusId", bus.BusId);
                cmd.Parameters.AddWithValue("@Make", bus.Make);
                cmd.Parameters.AddWithValue("@Model", bus.Model);
                cmd.Parameters.AddWithValue("@NoOfSeats", bus.NoOfSeats);
                int result=cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException ex)
            {
                msg = ex.Message;
                msg = "Data updating failed!!";
                return msg;
            }       
            return msg;

        }


       public  RetrieveBusInfo RetrieveBusInfo()
        {
            ABCTourDB_BasharJebryEntities context = new ABCTourDB_BasharJebryEntities();

            RetrieveBusInfo RetrieveInfo = new RetrieveBusInfo();
            List<BusInfo> RetrieveInfoList = new List<BusInfo>();
            RetrieveInfoList = context.BusInfoes.ToList();
            RetrieveInfo.dataset = RetrieveInfoList;         
            return RetrieveInfo;           
        }

       public  FoundRecord FindABus(FindABus bus)
        {
            ABCTourDB_BasharJebryEntities context = new ABCTourDB_BasharJebryEntities();


            FoundRecord ChosenInfo = new FoundRecord();

            try {
                var updatedInfo = context.BusInfoes.Find(bus.BusId);
                ChosenInfo.BusId = updatedInfo.BusId;
                ChosenInfo.Make = updatedInfo.Make;
                ChosenInfo.Model = updatedInfo.Model;
                ChosenInfo.NoOfSeats = updatedInfo.NoOfSeats;
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException ex)
            {
                MessageBox.Show(ex.Message);
            }

            return ChosenInfo;





            }
    }
}
