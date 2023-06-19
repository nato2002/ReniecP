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
        DataSet validaruser(ConsultaLogin loginfo);
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
        DataSet BuscarNombreSede(RegSede regdet);

        [OperationContract]
        DataSet BuscarDireccionSede(RegSede regdet);

        [OperationContract]
        DataSet BuscarSolicitudID(RegSolicitud regdetsol);

        [OperationContract]
        DataSet BuscarEstadoSolicitud(RegSolicitud regdetsol);

        [OperationContract]
        DataSet GetRegSolDetails();

    }
}
