using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;

namespace CarShowRoom.Code
{
   public class Query_DB
    {
        BussinessLogic b1 = new BussinessLogic();

        public String USER_EMAIL
        {
            set;
            get;
        }
        public String PASSWORD
        {
            set;
            get;
        }
        public Int32 USER_TYPE
        {
            set;
            get;
        }
        public String ADDRESS
        {
            set;
            get;
        }
        public String MOBILE
        {
            set;
            get;
        }
        public String NAME
        {
            set;
            get;
        }
        public int ID
        {
            set;
            get;
        }



        public void FillCarModel(ComboBox c)
        {
            String query = "select CName from CarModel";
            b1.FillComboBox(c, query);
        }




        public void FillCarQuantity(ComboBox c,String model)
        {
            String query = string.Format("select id from CarModel where [CName]='{0}'",model);
            b1.FillComboBox2(c, query);
        }






        public String CarQuantityId(String model,string color) {

            

            String query = string.Format("select id from CarModel where [CName]='{0}'", model);
            OleDbDataReader rece = b1.SelectQuery(query);
             while (rece.Read()){

                 string quer = string.Format("select id from CarQuantity where [CarModelId]= {0} and [Color]='{1}'", rece[0],color);
                 OleDbDataReader rec = b1.SelectQuery(quer);
                 while (rec.Read()){
                     return rec[0].ToString();
                 }
             }
             return "";
        }





        public  String CarQuantityNumber(String cqi) { 

           

            String quer = string.Format("select Quantity from CarQuantity where [id]= {0}",cqi);
            OleDbDataReader rec = b1.SelectQuery(quer);
            while (rec.Read()){
                return rec[0].ToString();
            }
            return "";
        }





        public bool UpdateCarQuantity(int oq,String qi) {

            string query = string.Format("update CarQuantity set [Quantity]={0} where [id]={1}",oq,qi);
            if (b1.NonQuery(query) == 1)
            {
                return true;
            }
            return false;
        }




        public bool CarCartupdate(int qi)
        {

            string query = string.Format("update CarQuantity set [Quantity]=Quantity-1 where [id]={0}",qi);
            if (b1.NonQuery(query) == 1)
            {
                return true;
            }
            return false;
        }




        public bool CheckAvail(String model,string color) {
            if (Convert.ToInt32(CarQuantityNumber(CarQuantityId(model, color))) > 0)
            {
                return true;
            }
            else { return false; }

        }





        public bool CheckUser(Query_DB cdb)
        {
            bool temp = false;
            String query = String.Format("select count(*) from UserData where Email='{0}'", cdb.USER_EMAIL);
            OleDbDataReader rec = b1.SelectQuery(query);
            while (rec.Read())
            {
                if (Convert.ToInt32(rec[0].ToString()) >= 1)
                {
                    temp = true;
                }
            }
            return temp;
        }


        public int  GetMaxID(String tab){

            String query = String.Format("Select Max(id) From {0}",tab);
            OleDbDataReader rec = b1.SelectQuery(query);
            while (rec.Read())
            {
                if (!rec[0].ToString().Equals(""))
                {
                    return Convert.ToInt32(rec[0].ToString());
                }
                else {
                    return 0;
                }
            }

            return 0;
        }

       
       
       
       public bool OrderUpdate(int id,int stu,int cqid) {
            
             string query = string.Format("update Cart set [Status]='{0}' where [ID]={1}",stu,id);
             if (b1.NonQuery(query) == 1)
             {

                 if (stu == 2)
                 {
                     string query2 = string.Format("update CarQuantity set [Quantity]=Quantity+1 where [id]={0}", cqid);
                     if (b1.NonQuery(query2) == 1) {
                         return true;
                     }
                 }
                 return true;
             }
             return false;
        }





        public bool CreateUser(Query_DB cdb)
        {
            
            bool temp = false;
            String query = String.Format("insert into UserData values('{0}','{1}','{2}','{3}','{4}',{5},{6}+1)", cdb.NAME, cdb.USER_EMAIL, cdb.MOBILE, cdb.PASSWORD, cdb.ADDRESS, cdb.USER_TYPE, GetMaxID("UserData"));
            if (b1.NonQuery(query) == 1)
            {
                temp = true;
            }
            return temp;
        }


        public bool VerifyUser(Query_DB cdb)
        {
            
            string query = string.Format("select count(*) from UserData where Email='{0}' and Password = '{1}'", cdb.USER_EMAIL, cdb.PASSWORD);
            OleDbDataReader rec = b1.SelectQuery(query);

            while (rec.Read())
            {
                if (rec[0].ToString().Equals("1"))
                {
                    return true;
                }
            }
            return false;
        }





        public Query_DB GetUserDetails(Query_DB cdb)
        {

            string query = string.Format("select id,Name,Email,Mobile,Password,Address,UserType from UserData where Email='{0}' and Password = '{1}'", cdb.USER_EMAIL, cdb.PASSWORD);
            OleDbDataReader rec = b1.SelectQuery(query);

            while (rec.Read())
            {
                if (!rec[0].ToString().Equals(" ") && Convert.ToInt32(rec[0].ToString()) >=1)
                {
                    Query_DB utb = new Query_DB();
                    utb.ID = Convert.ToInt32(rec[0].ToString());
                    utb.NAME = rec[1].ToString();
                    utb.USER_EMAIL = rec[2].ToString();
                    utb.MOBILE = rec[3].ToString();
                    utb.PASSWORD = rec[4].ToString();
                    utb.ADDRESS = rec[5].ToString();
                    utb.USER_TYPE = Convert.ToInt32(rec[6].ToString());
                    return utb;
                }
            }
            return null;
        }





        public bool CartAdd(Query_DB cdb,String token,int cid)
        {

            bool temp = false;
            String query = String.Format("insert into Cart values({0}+1,{1},'{2}',{3},'{4}','{5}')", GetMaxID("Cart"), cdb.ID, DateTime.Now.ToString(), cid, "0",token);
            if (b1.NonQuery(query) == 1)
            {
                temp = true;
            }
            return temp;
        }





        public bool TestDriveAdd(Query_DB cdb, int cid)
        {

            bool temp = false;
            String query = String.Format("insert into TestDrive values({0}+1,{1},{2},'{3}','{4}')", GetMaxID("TestDrive"), cdb.ID,cid,"0", DateTime.Now.ToString());
            if (b1.NonQuery(query) == 1)
            {
                temp = true;
            }
            return temp;
        }



        public bool VerifyAddUser(Query_DB cdb)
        {

            string query = string.Format("select count(*) from UserData where Email='{0}' and Password = '{1}' and UserType = 1", cdb.USER_EMAIL, cdb.PASSWORD);
            OleDbDataReader rec = b1.SelectQuery(query);

            while (rec.Read())
            {
                if (rec[0].ToString().Equals("1"))
                {
                    return true;
                }
            }
            return false;
        }

        public void UserViewAll(DataGridView dg)
        {
            string query = "select Name,Email,Mobile,Address from UserData where UserType=0";
            b1.filldataGrid(dg, query);
        }


        public void TestDriveViewAll(DataGridView dg)
        {
            string query = "select U.Name,U.Email,U.Mobile,U.Address,C.CName,Q.Color,T.Status,T.Time  from TestDrive T, UserData U, CarModel C, CarQuantity Q  where T.CarQuantityId=Q.ID and Q.CarModelId=C.ID and T.UserId=U.id";
            b1.filldataGrid(dg, query);
        }


        public void CartViewAll(DataGridView dg)
        {
            string query = "select U.Name,U.Email,U.Mobile,U.Address,C.CName,Q.Color,T.Status,T.Time,T.Token,T.ID as cid,T.CarQuantityId  as cqid  from Cart T, UserData U, CarModel C, CarQuantity Q  where T.CarQuantityId=Q.ID and Q.CarModelId=C.ID and T.UserId=U.id and T.Status <> '1'";
            b1.filldataGrid(dg, query);
        }


        public void SellViewAll(DataGridView dg)
        {
            string query = "select U.Name,U.Email,U.Mobile,U.Address,C.CName,Q.Color,T.Status,T.Time,T.Token  from Cart T, UserData U, CarModel C, CarQuantity Q  where T.CarQuantityId=Q.ID and Q.CarModelId=C.ID and T.UserId=U.id and T.Status='1'";
            b1.filldataGrid(dg, query);
        }

        public void FeedbackView(DataGridView dg)
        {
            string query = "select Name,Msg from UserData,Feedback where Feedback.ID=UserData.id";
            b1.filldataGrid(dg, query);
        }



        public bool ProfileUpdate(Query_DB cdbe)
        {

            string query = string.Format("update UserData set [Name]='{0}',[Email]='{1}',[Mobile]='{2}',[Address]='{3}'  where [id]={4}", cdbe.NAME,cdbe.USER_EMAIL,cdbe.MOBILE,cdbe.ADDRESS,cdbe.ID);
            if (b1.NonQuery(query) == 1)
            {
                return true;
            }
            return false;
        }


        public bool ChangePassword(Code.Query_DB cdbe)
        {
            bool temp = false;
            string query = string.Format("update UserData set [Password]='{0}' where [id]={1}", cdbe.PASSWORD, cdbe.ID);
            if (b1.NonQuery(query) == 1)
            {
                temp = true;
            }
            return temp;
        }

        public void MyOrderView(DataGridView dg,int userid)
        {
            string query = string.Format("select C.CName,Q.Color,T.Status,T.Time,T.Token  from Cart T, CarModel C, CarQuantity Q  where T.CarQuantityId=Q.ID and Q.CarModelId=C.ID and T.UserId={0}",userid);
            b1.filldataGrid(dg, query);
        }


        public void MyTestDriveView(DataGridView dg, int userid)
        {
            string query = string.Format("select C.CName,Q.Color,T.Status,T.Time  from TestDrive T, CarModel C, CarQuantity Q  where T.CarQuantityId=Q.ID and Q.CarModelId=C.ID and T.UserId={0}", userid);
            b1.filldataGrid(dg, query);
        }

        public bool FeedbackAdd(Query_DB cdb, String msg)
        {

            bool temp = false;
            String query = String.Format("insert into Feedback values({0}+1,{1},'{2}')", GetMaxID("Feedback"), cdb.ID,msg);
            if (b1.NonQuery(query) == 1)
            {
                temp = true;
            }
            return temp;
        }

    }
}
