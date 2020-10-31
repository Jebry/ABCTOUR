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
    class Class2
    {
        System.Data.SqlClient.SqlConnection conn;
        System.Data.SqlClient.SqlCommand cmd;
        public void delete(DeleteABus bus )
        {
            conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\project of c# summer 2020\FinalExam\FinalExam-BasharJebry\ABCTourDB_BasharJebry.mdf;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework");
            conn.Open();
            cmd = new SqlCommand("Delete from BusInfo where BusId=@Id", conn);
            cmd.Parameters.AddWithValue("@Id", bus.BusId);
            int result = cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void insert(InsertABus bus)
        {
            SqlConnection conn;
            SqlCommand cmd;
            conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\project of c# summer 2020\FinalExam\FinalExam-BasharJebry\ABCTourDB_BasharJebry.mdf;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework");
            conn.Open();
            cmd = new SqlCommand("Insert into BusInfo values(@BusId, @Make, @Model,@NoOfSeat)", conn);
            cmd.Parameters.AddWithValue("@BusId", bus.BusId);
            cmd.Parameters.AddWithValue("@Make", bus.Make);
            cmd.Parameters.AddWithValue("@Model", bus.Model);
            cmd.Parameters.AddWithValue("@NoOfSeat", bus.NoOfSeats);
            int result = cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void update(UpdateABus bus)
        {
            SqlConnection conn;
            SqlCommand cmd;
            conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\project of c# summer 2020\FinalExam\FinalExam-BasharJebry\ABCTourDB_BasharJebry.mdf;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework");
            conn.Open();
            cmd = new SqlCommand("Update BusInfo set Model=@Model, Make=@Make ,NoOfSeats=@NoOfSeats where BusId=@BusId", conn);
            cmd.Parameters.AddWithValue("@BusId", bus.BusId);
            cmd.Parameters.AddWithValue("@Make", bus.Make);
            cmd.Parameters.AddWithValue("@Model", bus.Model);
            cmd.Parameters.AddWithValue("@NoOfSeats", bus.NoOfSeats);
            int result = cmd.ExecuteNonQuery();
            conn.Close();
        }
       
    }
}
