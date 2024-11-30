using System;
using System.Collections.Generic;
using System.Text;
using Firebase.Database;

namespace MVVM_implementacion_EMO.Conexion
{
    public class Cconexion
    {
        public static FirebaseClient firebase = new FirebaseClient("https://mvvmemo-default-rtdb.firebaseio.com/");
    }
}
