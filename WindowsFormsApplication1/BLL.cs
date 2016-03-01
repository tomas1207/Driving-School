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
            static public int deletecarro(string id)
            {
                DAL dal = new DAL();
                SqlParameter[] sql = new SqlParameter[] { 
                    new SqlParameter("@id", id)
                };

                return dal.executarNonQuery("Delete from Carros where id = @Id", sql);
            }
            static public int UpdateCarro(string Marca, string matricula, string modelo, string tipo, string utilizaçao, string id)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                   // new SqlParameter("@id", id),
                new SqlParameter("@Marca", Marca),
                new SqlParameter("@Matricula",matricula),
                new SqlParameter("@Modelo", modelo),
                new SqlParameter("@Tipo", tipo),
                new SqlParameter("@Utilizaçao", utilizaçao),
                new SqlParameter("@id", id)
            };
                return dal.executarNonQuery("Update Carros set Marca = @Marca, matricula = @Matricula, modelo = @Modelo, tipo = @tipo, utilizaçao = @Utilizaçao where id = @id", sqlParams);
            }

       
        }
            public class Login
            {
                
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

                static public int insertRegisto(string Nome, string DN, string Morada, string Contacto, string Cartac, string Email, string Categoria, string tipo, string pass)
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
                static public int deletregisto(string id)
                {
                    DAL dal = new DAL();
                    SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@id", id),
                };
                    return dal.executarNonQuery("Delete from Registo Where id = @id", sqlParams);

                }
                static public int UpdateRegisto(string Nome, string DN, string Morada, string Contacto, string Cartac, string Email, string Categoria, string tipo, string pass, string id)
                {
                    DAL dal = new DAL();
                    SqlParameter[] sql = new SqlParameter[]{
           
                new SqlParameter("@Nome", Nome),
                new SqlParameter("@DN", DN),
                new SqlParameter("@Email", Email),
                new SqlParameter("@Morada", Morada),
                new SqlParameter("@Contacto", Contacto),
                new SqlParameter("@Cartac", Cartac),
                new SqlParameter("@Categoria", Categoria),
                  new SqlParameter("@Tipo", tipo),
                  new SqlParameter("@pass", pass),
                  new SqlParameter("@id", id)
            };
                    return dal.executarNonQuery("Update Registo set DN = @DN , Email = @Email, Morada = @Morada , Contacto = @Contacto, Cartac = @Cartac , Categoria = @Categoria,tipo = @Tipo, pass = @pass, Nome = @Nome where id = @id ", sql);

                }


            }

        }
    }





    


    