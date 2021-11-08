using Contractflow.Models.Database;
using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.SqlClient;
using Contractflow.Constants;
using System.Windows.Forms;

namespace Contractflow.Services
{
    public class AuthService
    {
        ContractflowDbContext databaseContext;

        public AuthService()
        {
            databaseContext = new ContractflowDbContext();
        }

        public async Task<bool> Login(string Username, string Password)
        {
            try
            {
                SqlParameter[] sqlParams = new SqlParameter[]
                {
                    new SqlParameter()
                    {
                        ParameterName = "@pUsername",
                        SqlDbType = System.Data.SqlDbType.VarChar,
                        Size = 100,
                        Direction = System.Data.ParameterDirection.Input,
                        Value = Username
                    },
                    new SqlParameter()
                    {
                        ParameterName = "@pPassword",
                        SqlDbType = System.Data.SqlDbType.VarChar,
                        Size = 50,
                        Direction = System.Data.ParameterDirection.Input,
                        Value = Password
                    },
                   new SqlParameter()
                   {
                       ParameterName = "@responseMessage",
                       SqlDbType = System.Data.SqlDbType.VarChar,
                       Size = 50,
                       Direction = System.Data.ParameterDirection.Output
                   }
                };

                await databaseContext.Database.ExecuteSqlInterpolatedAsync($"sp_Login {sqlParams[0]}, {sqlParams[1]}, {sqlParams[2]} OUT");

                switch (sqlParams[2].Value)
                {
                    case AuthConstants.USER_NOT_FOUND:
                        MessageBox.Show(
                            "El nombre de usuario o email ingresado no corresponde a ningun usuario registrado en el sistema.",
                            "Usuario no encontrado",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                            );
                        return false;

                    case AuthConstants.WRONG_PASSWORD:
                        MessageBox.Show(
                            "La contraseña ingresada no corresopnde al usuario solicitado.",
                            "Contraseña incorrecta",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                            );
                        return false;

                    case AuthConstants.LOGIN_SUCCESS:
                        MessageBox.Show(
                            "¡Bienvenido al sistema!.",
                            "Inicio de sesión correcto",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );
                        return true;
                    default:
                        return false;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"An exception occurred while login: {e.Message}");
                return false;
            }
        }
    }
}
