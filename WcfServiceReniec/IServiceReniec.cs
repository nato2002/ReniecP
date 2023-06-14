using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceReniec
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IServiceReniec" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServiceReniec
    {
        //Login
        [OperationContract]
        string validaruser(ConsultaLogin loginfo);
        [OperationContract]
        string RegistrartUsuario(ConsultaLogin userInfo);

        //Registrar Sedes
        [OperationContract]
        string InsertUserRegDetails(RegSede regdet);

        [OperationContract]
        DataSet GetUserRegDetails();

        [OperationContract]
        DataSet FetchUpdatedRecords(RegSede regdet);

        [OperationContract]
        string UpdateUserRegDetails(RegSede regdet);

        [OperationContract]
        bool DeleteUserRegDetails(RegSede regdet);
        [OperationContract]
        string Tramite(Tramite tramite);
        [OperationContract]
        List<String> VerProcesoTramite(Tramite tramite);
        [OperationContract]
        string ColocarProceso(Tramite tramite);
    }
}
