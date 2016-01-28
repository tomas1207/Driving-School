using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DataAccessLayer;
using System.Data;
using System.Data.SqlClient;

namespace BusinessLogicLayer
{
    public class BLL
    {

        public class Carros
        {
            static public DataTable Load()
            {
                DAL dal = new DAL();
                return dal.executarReader("select * from Carros", null);
            }
            static public int insertCarros(string Marca, string matricula, string modelo, string tipo, string utilizaçao)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@Marca", Marca),
                new SqlParameter("@Matricula",matricula),
                new SqlParameter("@Modelo", modelo),
                new SqlParameter("@Tipo", tipo),
                new SqlParameter("@Utilizaçao", utilizaçao),
              
                
        };


                return dal.executarNonQuery("INSERT into Carros (Marca, matricula,modelo,tipo,utilizaçao) VALUES(@Marca,@Matricula,@Modelo,@Tipo,@Utilizaçao)", sqlParams);

            }
            static public int deletecarro(string id){ 
                DAL dal = new DAL(); 
                SqlParameter[] sql = new SqlParameter[] { 
                    new SqlParameter("@id", id)
                };

                return dal.executarNonQuery("Delete from Carros where id = @Id  ",sql); 
            }
        }
        public class Login
        {
            static public DataTable Load()
            {
                DAL dal = new DAL();
                return dal.executarReader("select * from Login", null);
            }
            static public int insertLogin(string UserName, string Password)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@UserName", UserName),
                new SqlParameter("@Password", Password),
             
           };

                return dal.executarNonQuery("INSERT into Login (UserName,Password) VALUES(@UserName,@Password)", sqlParams);
            

            }
            static public DataTable LoginSystem(string Nome, string Pass)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                   new SqlParameter("@Nome", Nome),
                   new SqlParameter("@Pass", Pass)
                  
                };
                return dal.executarReader("SELECT * from Registo Where Nome = @Nome and Pass = @Pass ", sqlParams);

            }

        }


        public class Registo
        {
            static public DataTable Load()
            {
                DAL dal = new DAL();
                return dal.executarReader("select * from Registo", null);
            }

            static public int insertRegisto(string Nome, string DN, string Morada, string Contacto, string Cartac, string Email, string Categoria, string tipo , string pass)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@Nome", Nome),
                new SqlParameter("@DN", DN),
                new SqlParameter("@Email", Email),
                new SqlParameter("@Morada", Morada),
                new SqlParameter("@Contacto", Contacto),
                new SqlParameter("@Cartac", Cartac),
                new SqlParameter("@Categoria", Categoria),
                  new SqlParameter("@Tipo", tipo),
                  new SqlParameter("@pass", pass),

        };


                return dal.executarNonQuery("INSERT into Registo (Nome,DN,Email,Morada,Contacto,Cartac,Categoria,tipo, pass) VALUES(@Nome,@DN,@Email,@Morada,@Contacto,@Cartac,@Categoria,@Tipo,@pass)", sqlParams);

            }
            static public int deletregisto(String Nome)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@Nome", Nome),
                };
                return dal.executarNonQuery("Delete from Registo Where Nome = @Nome", sqlParams);

            }

            static public int updateregisto(string Nome, string DN, string Morada, string Contacto, string Cartac, string Email, string Categoria, string tipo, string pass)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
               new SqlParameter("@Nome", Nome),
                new SqlParameter("@DN", DN),
                new SqlParameter("@Email", Email),
                new SqlParameter("@Morada", Morada),
                new SqlParameter("@Contacto", Contacto),
                new SqlParameter("@Cartac", Cartac),
                new SqlParameter("@Categoria", Categoria),
                  new SqlParameter("@Tipo", tipo),
                  new SqlParameter("@pass", pass),
                };
                return dal.executarNonQuery("Update Registo set DN = @DN , Email = @Email , Morada = @Morada , Contacto = @Contacto , Cartac = @Cartac , Categoria = @Categoria , Tipo = @Tipo, Pass = @Pass Where Nome = @Nome ", sqlParams);

            }

            
        }

    }
}




    


    