using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFrm_ErrorHandles.Handling_Constants
{

    public class ErrorHandling_Manager
    {
        Attribute VB_Name = "ErrorHandling_Manager";
        public enum ERROR_LAYERS
        {
            DBL = 1 ,          // DATABASE LAYER
            BLL = 2 ,         // BUSINESS LOGIC LAYER
            UIL = 3 ,        // USER INTERFACE LAYER
            UNKNOWN = 4     // UNKNOWN
        };

        public enum ERRORTYPES
        {
            ERROR_TYPE_CUSTOM_DBL = 1   ,       // خطا معروف في عمليات قواعد البيانات
            ERROR_TYPE_UNKNOWN_DBL = 2  ,      // خطا غير معروف في عمليات قواعد البيانات
            ERROR_TYPE_CUSTOM_BLL = 3   ,     // خطا معروف ناتج عن تنفيذ متطلبات وشروط النظام  - حدود النظام - BUSINESS LOGIC
            ERROR_TYPE_UNKNOWN_BLL = 4  ,    // خطا غير معروف ناتج عن تنفيذ متطلبات وشروط النظام  - حدود النظام - BUSINESS LOGIC
            ERROR_TYPE_CUSTOM_UIL = 5   ,   // خطا معروف في واجهة المستخدم
            ERROR_TYPE_UNKNOWN_UIL = 6  ,  // خطا غير معروف في واجهة المستخدم
            ERROR_TYPE_UNKNOWN = 7        // خطا غير معروف وغير متوقع حدوثه
        };

        public void Get_ErrorLayer(long ErrNumber)
        {
            
        }
    }

        
}
