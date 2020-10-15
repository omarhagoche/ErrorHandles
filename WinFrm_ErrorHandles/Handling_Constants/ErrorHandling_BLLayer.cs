using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFrm_ErrorHandles.Handling_Constants
{
    public class ErrorHandling_BLLayer
    {
            /* TODO ERROR: Skipped SkippedTokensTrivia */
            Attribute VB_Name = "ErrorHandling_BLLayer";
            // BLL CustomerErrors List
            public const var MaxBLLErrorNumber_Unknown = 65000;
            public const var BLL_DeleteLastDepartmentKeyError = MaxBLLErrorNumber_Unknown - 1;

            // لايمكن حذف أخر باركود لوحدة المخزون الرئيسية للصنف
            public const var BLL_CusError_Product_NotAllowToDeleteLastBarcodeForBasedUOM = MaxBLLErrorNumber_Unknown - 2;
            public const var BLL_CusError_Product_NotAllowToDeleteLastBarcodeForBasedUOMDescription = " لايمكن حذف Barcode المطلوب ، يجب أن تحتوي وحدة المخزون الاساسية علي Barcode واحد علي الأقل ";

            // لايمكن حذف وحدة المخزون الاساسية / الاصغر
            public const var BLL_CusError_Product_NotAllowToDeleteBasedUOM = MaxBLLErrorNumber_Unknown - 3;
            public const var BLL_CusError_Product_NotAllowToDeleteBasedUOMDescription = "لايسمح النظام بحذف وحدة المخزون الأساسية للصنف...";

            // لايمكن حذف وحدة مخزون لصنف لسبب إستعمالها ضمن الوحدات الاكثر إستعمالاً
            public const var BLL_CusError_Product_NotAllowToDeleteProductUOM_IsUsedOnDefaultUOMs = MaxBLLErrorNumber_Unknown - 4;
            public const var BLL_CusError_Product_NotAllowToDeleteProductUOM_IsUsedOnDefaultUOMsDescription = " لايمكن حذف وحدة المخزون بسبب إستعمالها كوحدة ضمن الوحدات الاكثر إستعمالاً. يمكنك إجراء عملية الحذف بعد تعديل الوحدات الاكثر إستعمالاً لهذا الصنف...";

            // لايمكن إستلام الاصناف من فاتورة الشراء بعد الإستلام الكلي أو بعد الترحيل لحساب المورد
            public const var BLL_CustomError_NoAllowToReceivePurchaseInvoiceItems = MaxBLLErrorNumber_Unknown - 5;
            public const var BLL_CustomError_NoAllowToReceivePurchaseInvoiceItemsDescription = "لا يسمح النظام بإجراء عملية الإستلام لإصناف فاتورة الشراء بعد تغيير حالة الفاتورة إلي الاستلام الكلي أو بعد الترحيل لحساب االمورد";

            // لايمكن تعديل أصناف فاتورة الشراء بعد ترحيلها لحساب المورد
            public const var BLL_CustomError_NoAllowToModifiPurchaseInvoice = MaxBLLErrorNumber_Unknown - 6;
            public const var BLL_CustomError_NoAllowToModifiPurchaseInvoiceDescription = "لا يمكن (الإضافة - التعديل - الحذف) في أصناف فاتورة الشراء بعد ترحيلها لحساب الممؤل / المورد";

            // لايمكن تعديل مصاريف فاتورة الشراء بعد ترحيلها لحساب المورد
            public const var BLL_CustomError_NoAllowToModifiPurchaseInvoiceExpenses = MaxBLLErrorNumber_Unknown - 7;
            public const var BLL_CustomError_NoAllowToModifiPurchaseInvoiceExpensesDescription = "لا يمكن التعديل في مصاريف فاتورة الشراء بعد ترحيلها لحساب الممؤل / المورد";

            // لايمكن تعديل كمية الصنف بفاتورة الشراء بعد إستلامه
            public const var BLL_CustomError_NoAllowToModifiPurchaseInvoiceItemQYT = MaxBLLErrorNumber_Unknown - 8;
            public const var BLL_CustomError_NoAllowToModifiPurchaseInvoiceItemQYTDescription = "لا يمكن التعديل في كمية الصنف بعد الإستلام ...";

            // لايمكن حذف الصنف من فاتورة الشراء بعد إستلامه
            public const var BLL_CustomError_NoAllowToDeletePurchaseInvoiceItem = MaxBLLErrorNumber_Unknown - 8;
            public const var BLL_CustomError_NoAllowToDeletePurchaseInvoiceItemDescription = "لا يمكن حذف الأصناف من فاتورة الشراء بعد إستلامها بالمخزن ...";

            // لايمكن حذف فاتورة الشراء بعد البدء في إستلام الاصناف
            public const var BLL_CustomError_NoAllowToDeletePurchaseInvoice = MaxBLLErrorNumber_Unknown - 9;
            public const var BLL_CustomError_NoAllowToDeletePurchaseInvoiceDescription = "لايمكن حذف فاتورة الشراء بالكامل بعد البدء في إستلام الاصناف... يمكن حذف الأصناف التي لم يتم إستلامها من الفاتورة";

            // لايمكن حذف فاتورة الشراء لوجود مصاريف مسجله علي الفاتورة
            public const var BLL_CustomError_NoAllowToDeletePurchaseInvoiceWithExpenes = MaxBLLErrorNumber_Unknown - 10;
            public const var BLL_CustomError_NoAllowToDeletePurchaseInvoiceWithExpenesDescription = "لايمكن حذف فاتورة الشراء بالكامل بعد إدخال مصروفات للفاتورة. قم بحذف المصاريف أولاً...";

            // لايمكن أن تكون قيمة التخفيض أكبر من قيمة الصنف
            public const var BLL_CustomError_NoAllowToSetDiscountAmountBiggerThanItemAmount = MaxBLLErrorNumber_Unknown - 11;
            public const var BLL_CustomError_NoAllowToSetDiscountAmountBiggerThanItemAmountDescription = "'لايمكن أن تكون قيمة التخفيض أكبر من قيمة الصنف ...";

            // يجب إختيار قيم صحيحة
            public const var BLL_CustomError_YouMustSelectValues = MaxBLLErrorNumber_Unknown - 12;
            public const var BLL_CustomError_YouMustSelectValuesDescription = "يجب إدخال قيم صحيحة قبل تنفيذ الإجراء ...";

            // لايمكن إستلام الاصناف - يجب إدخال تاريخ الصلاحية
            public const var BLL_CustomError_NotAllowToReceiveProductsYouMustEnterExprieDate = MaxBLLErrorNumber_Unknown - 13;
            public const var BLL_CustomError_NotAllowToReceiveProductsYouMustEnterExprieDateDescription = "لايمكن إستلام الأصناف ألا بعد إدخال تاريخ صلاحية صحيح ...";

            // لايمكن ترحيل الفاتورة - لم يتم ربط المورد بقائمة الحسابات الرئيسية
            public const var BLL_CustomError_NotAllowPostInvoiceSupplierNotLinkedToAccountAccount = MaxBLLErrorNumber_Unknown - 14;
            public const var BLL_CustomError_NotAllowPostInvoiceSupplierNotLinkedToAccountAccountDescription = "لايمكن ترحيل فاتورة الشراء. لم يتم ربط ملف المورد بقائمة الحسابات الرئيسية";

            // لايمكن ترحيل الفاتورة - يجب إستلام كل الاصناف المدرجة بالفاتورة قبل الترحيل لحساب المورد
            public const var BLL_CustomError_NotAllowPostInvoiceMustReceiveAllItems = MaxBLLErrorNumber_Unknown - 15;
            public const var BLL_CustomError_NotAllowPostInvoiceMustReceiveAllItemsDescription = "لايمكن ترحيل فاتورة الشراء. يجب إستلام كل الأصناف المدرجة بالفاتورة قبل الترحيل";

            // لايمكن ترحيل الفاتورة - لم يتم ربط المصروفات بقائمة الحسابات الرئيسية
            public const var BLL_CustomError_NotAllowPostInvoiceExpenseNotLinkedToAccount = MaxBLLErrorNumber_Unknown - 16;
            public const var BLL_CustomError_NotAllowPostInvoiceExpenseNotLinkedToAccountDescription = "لايمكن ترحيل فاتورة الشراء. لم يتم ربط المصروفات بقائمة الحسابات الرئيسية";

            // لايمكن ترحيل الفاتورة - لم يتم ربط أقسام المخزون بقائمة الحسابات الرئيسية
            public const var BLL_CustomError_NotAllowPostInventoryDepartmentsNotLinkedToAccount = MaxBLLErrorNumber_Unknown - 17;
            public const var BLL_CustomError_NotAllowPostInventoryDepartmentsNotLinkedToAccountDescription = "لايمكن ترحيل فاتورة الشراء. لم يتم ربط أقسام المخزون الرئيسية بقائمة الحسابات الرئيسية";

            // لايمكن ترحيل فاتورة الشراء - تم ترحيلها مسبقاً
            public const var BLL_CustomError_NotAllowPostPurchaseInvoice_IsAlreadyPosted = MaxBLLErrorNumber_Unknown - 18;
            public const var BLL_CustomError_NotAllowPostPurchaseInvoice_IsAlreadyPostedDescription = "لايمكن ترحيل فاتورة الشراء للحسابات  - تم ترحيلها مسبقاً...";

            // لايمكن ترحيل قيد اليومية - تم ترحيله مسبقاً
            public const var BLL_CustomError_NotAllowPostJournalEntry_IsAlreadyPosted = MaxBLLErrorNumber_Unknown - 19;
            public const var BLL_CustomError_NotAllowPostJournalEntry_IsAlreadyPostedDescription = "لايمكن ترحيل قيد اليومية - تم ترحيله مسبقاً...";

            // لايمكن ترحيل قيد اليومية - يجب أن يكون إجمالي الحركات المدينة والدائنة بنفس القيمة
            public const var BLL_CustomError_NotAllowPostJournalEntry_CreditAmountNotEquelToDebitAmount = MaxBLLErrorNumber_Unknown - 20;
            public const var BLL_CustomError_NotAllowPostJournalEntry_CreditAmountNotEquelToDebitAmountDescription = "لايمكن ترحيل قيد اليومية - يجب أن يكون إجمالي الحركات المدينة والدائنة بنفس القيمة";

            // لايمكن البدء في عملية بيع بنقطة البيع طالما توجد عملية مفتوحة
            public const var BLL_CustomError_NotAllowToStartPOSsalesTransaction_CuaseThereAreAnActiveTransaction = MaxBLLErrorNumber_Unknown - 21;
            public const var BLL_CustomError_NotAllowToStartPOSsalesTransaction_CuaseThereAreAnActiveTransactionDescription = "لايمكن البدء في عملية البيع... يجب إستكمال العملية الحالية أولاً";

            // لايمكن البدء في عملية ترجيع بنقطة البيع طالما توجد عملية مفتوحة
            public const var BLL_CustomError_NotAllowToStartPOSRefundTransaction_CuaseThereAreAnActiveTransaction = MaxBLLErrorNumber_Unknown - 22;
            public const var BLL_CustomError_NotAllowToStartPOSRefundTransaction_CuaseThereAreAnActiveTransactionDescription = "لايمكن البدء في عملية الإسترجاع المطلوبة... يجب إستكمال العملية الحالية أولاً";

            // النظام يسمح فقط بتجميد فواتير البيع ولا يسمح بتجميد فواتير الاسترجاع
            public const var BLL_CustomError_POS_NotAllowToHoldRefundTransaction = MaxBLLErrorNumber_Unknown - 23;
            public const var BLL_CustomError_POS_NotAllowToHoldRefundTransactionDescription = "النظام يسمح فقط بتجميد فواتير البيع ولا يسمح بتجميد فواتير الاسترجاع";

            // النظام يسمح فقط بتجميد فواتير البيع ولا يسمح بتجميد فواتير الإستبدال
            public const var BLL_CustomError_POS_NotAllowToHoldChangeTransaction = MaxBLLErrorNumber_Unknown - 24;
            public const var BLL_CustomError_POS_NotAllowToHoldChangeTransactionDescription = "النظام يسمح فقط بتجميد فواتير البيع ولا يسمح بتجميد فواتير الإستبدال";

            // لايمكن تجميد الفاتورة الحالية .. تم الوصول للحد الآعلى لعدد الفواتير المسموح بتجميدها
            public const var BLL_CustomError_POS_NotAllowToHoldMaxHoldInvoicesCountReached = MaxBLLErrorNumber_Unknown - 25;
            public const var BLL_CustomError_POS_NotAllowToHoldMaxHoldInvoicesCountReachedDescription = "لايمكن تجميد الفاتورة الحالية .. تم الوصول للحد الآعلى لعدد الفواتير المسموح بتجميدها";

            // لايمكن تجميد الفاتورة الحالية .. يجب إدراج الأصناف اولاً قبل التجميد
            public const var BLL_CustomError_POS_NotAllowToHoldNoItemsToHold = MaxBLLErrorNumber_Unknown - 26;
            public const var BLL_CustomError_POS_NotAllowToHoldNoItemsToHoldDescription = "لايمكن تجميد الفاتورة الحالية .. يجب إدراج ألاصناف أولاً ...";

            // لايمكن تنفيذ هذا الاجراء طالما توجد عملية مفتوحة
            public const var BLL_CustomError_NotAllowToExcuteThisAction_CuaseThereAreAnActiveTransaction = MaxBLLErrorNumber_Unknown - 27;
            public const var BLL_CustomError_NotAllowToExcuteThisAction_CuaseThereAreAnActiveTransactionDescription = "لايمكن تنفيذ الإجراء المطلوب... يجب إستكمال العملية الحالية أولاً";

            // يجب إدراج أصناف قبل إجراء التخفيض
            public const var BLL_CustomError_POS_NotAllowToDiscountNoItemsToDiscount = MaxBLLErrorNumber_Unknown - 28;
            public const var BLL_CustomError_POS_NotAllowToDiscountNoItemsToDiscountDescription = "لايمكن تنفيذ تنفيذ أي تخفيض ... يجب إدراج ألاصناف أولاً....";

            // لايوجد أي تخفيض يمكن تنفيذه علي هذه العملية
            public const var BLL_CustomError_POS_ThereIsNoDiscountsToApplyOnThisTransaction = MaxBLLErrorNumber_Unknown - 29;
            public const var BLL_CustomError_POS_ThereIsNoDiscountsToApplyOnThisTransactionDescription = "لايوجد أي تخفيض يمكن تنفيذه علي هذه العملية ...";

            // لايمكن التخفيض علي العملية الحالية / المجموع الجزئي = 0
            public const var BLL_CustomError_POS_NoneedToApplyDiscount_TransactionSubTotalIsZero = MaxBLLErrorNumber_Unknown - 30;
            public const var BLL_CustomError_POS_NoneedToApplyDiscount_TransactionSubTotalIsZeroDescription = "لايمكن إجراء تخفيضات علي هذه العملية - المجموع = 0 أو مجموع الأصناف القابلة للتخفيض = 0 ....";

            // لايمكن التخفيض علي العملية الحالية / جميع الاصناف المدرجة غير قابلة للتخفيض
            public const var BLL_CustomError_POS_NoneedToApplyDiscount_AllItemsAreNonDiscountable = MaxBLLErrorNumber_Unknown - 31;
            public const var BLL_CustomError_POS_NoneedToApplyDiscount_AllItemsAreNonDiscountableDescription = "لايمكن إجراء التخفيض علي هذه العملية - كل الأصناف المدرجة غير قابلة للتخفيض";

            // لايمكن التخفيض علي العملية الحالية / مجموع قيمة التخفيض اكبر من قيمة الأصناف القابلة للتخفيض
            public const var BLL_CustomError_POS_NoneedToApplyDiscount_AmountBigerThanDiscountableItemsSubTotal = MaxBLLErrorNumber_Unknown - 32;
            public const var BLL_CustomError_POS_NoneedToApplyDiscount_AmountBigerThanDiscountableItemsSubTotalDescription = "لايمكن إجراء التخفيض علي هذه العملية - قيمة التخفيض أكبر من مجموع قيمة الأصناف المتاحة للتخفيض";

            // لايمكن إنشاء جلسة عمل جديدة لهذه النقطة . يوجد حالياً جلسة مفتوحة
            public const var BLL_CustomError_POS_NotAllowToOpenShift_CuseThereAreOpendShift = MaxBLLErrorNumber_Unknown - 33;
            public const var BLL_CustomError_POS_NotAllowToOpenShift_CuseThereAreOpendShiftDescription = "لايمكن فتح أكثر من جلسة عمل لنفس نقطة المبيعات - يرجى التاكد وإعادة تسجيل الدخول";

            // لايمكن تنفيذ الاجراء المطلوب . لايوجد جلسة عمل مفتوحة حاليا
            public const var BLL_CustomError_POS_NotAllowToRunTheRequest_CuseThereAreNoOpendShift = MaxBLLErrorNumber_Unknown - 34;
            public const var BLL_CustomError_POS_NotAllowToRunTheRequest_CuseThereAreNoOpendShiftDescription = "لايمكن تنفيذ الاجراء المطلوب . لايوجد جلسة عمل مفتوحة حاليا";

            // لايمكن تنفيذ الاجراء المطلوب . لايمكن التعديل في الفاتورة بعد تطبيق التخفيض علي مستوى الفاتورة
            public const var BLL_CustomError_POS_NotAllowToRunTheRequest_CuseTransactionDiscountHasApplied = MaxBLLErrorNumber_Unknown - 35;
            public const var BLL_CustomError_POS_NotAllowToRunTheRequest_CuseTransactionDiscountHasAppliedDescription = "لايمكن تنفيذ الاجراء المطلوب. لقد قمت بتنفيذ التخفيض علي مستوى الفاتورة. لا يمكن التعديل بها بعد هذا الإجراء... ";

            // لايمكن إتلاف الكمية المطلوبة - مخزون الصنف لا يسمح
            public const var BLL_CustomError_Inv_NotAllowToDamageRequestQYT_CuaseItMoreThanStockOnHand = MaxBLLErrorNumber_Unknown - 36;
            public const var BLL_CustomError_Inv_NotAllowToDamageRequestQYT_CuaseItMoreThanStockOnHandDescription = "لايمكن إتلاف الكمية المطلوبة - مخزون الصنف لا يسمح";

            // لايمكن إتلاف الكمية المطلوبة - يجب إختيار تاريخ الصلاحية
            public const var BLL_CustomError_Inv_NotAllowToDamageRequestQYT_SelectExpiryDateFirst = MaxBLLErrorNumber_Unknown - 37;
            public const var BLL_CustomError_Inv_NotAllowToDamageRequestQYT_SelectExpiryDateFirstDescription = "لايمكن إتلاف الكمية المطلوبة - يجب إختيار تاريخ الصلاحية الذي سيتم إتلافه";

            // لايمكن إتلاف الكمية المطلوبة - تاريخ الصلاحية المطلوب إتلافه غير مسجل لهذا الصنف
            public const var BLL_CustomError_Inv_NotAllowToDamageRequestQYT_ExpiryDateNotExist = MaxBLLErrorNumber_Unknown - 38;
            public const var BLL_CustomError_Inv_NotAllowToDamageRequestQYT_ExpiryDateNotExistDescription = "لايمكن إتلاف الكمية المطلوبة - تاريخ الصلاحية المطلوب إتلافه غير مسجل لهذا الصنف...";

            // لايمكن إتلاف الكمية المطلوبة - الكمية أكبر من سجلات تاريخ الصلاحية الحالي
            public const var BLL_CustomError_Inv_NotAllowToDamageRequestQYT_QYTMoreThanExpiryDateQYT = MaxBLLErrorNumber_Unknown - 39;
            public const var BLL_CustomError_Inv_NotAllowToDamageRequestQYT_QYTMoreThanExpiryDateQYTDescription = "لايمكن إتلاف الكمية المطلوبة - الكمية أكبر من المتوفر في سجلات تاريخ الصلاحية الحالي...";

            // لايمكن إتلاف الكمية المطلوبة - تاريخ الصلاحية الذي تم إختيار لا يزال صالح
            public const var BLL_CustomError_Inv_NotAllowToDamageRequestQYT_SelectedExpireyDateStillUnExpired = MaxBLLErrorNumber_Unknown - 40;
            public const var BLL_CustomError_Inv_NotAllowToDamageRequestQYT_SelectedExpireyDateStillUnExpiredDescription = "لايمكن إتلاف الكمية المطلوبة - تاريخ الصلاحية الذي تم إختياره لايزال صالح...";


            // لايمكن ترحيل الفاتورة - لم يتم ربط الزبون بقائمة الحسابات الرئيسية
            public const var BLL_CustomError_NotAllowToPostInvoiceCustomerNotLinkedToAccountt = MaxBLLErrorNumber_Unknown - 41;
            public const var BLL_CustomError_NotAllowToPostInvoiceCustomerNotLinkedToAccounttDescription = "لايمكن ترحيل فاتورة البيع. لم يتم ربط ملف الزبون بقائمة الحسابات الرئيسية";

            // لايمكن ترحيل الفاتورة - يجب تسليم كل الاصناف المدرجة بالفاتورة قبل الترحيل لحساب الزبون
            public const var BLL_CustomError_NotAllowToPostInvoiceMustDeliverAllItems = MaxBLLErrorNumber_Unknown - 42;
            public const var BLL_CustomError_NotAllowToPostInvoiceMustDeliverAllItemsDescription = "لايمكن ترحيل فاتورة البيع. يجب تسليم كل الأصناف المدرجة بالفاتورة قبل الترحيل";

            // لايمكن ترحيل الفاتورة - لم يتم ربط المصروفات بقائمة الحسابات الرئيسية
            public const var BLL_CustomError_NotAllowToPostSalesInvoiceExpenseNotLinkedToAccount = MaxBLLErrorNumber_Unknown - 43;
            public const var BLL_CustomError_NotAllowToPostSalesInvoiceExpenseNotLinkedToAccountDescription = "لايمكن ترحيل فاتورة البيع. لم يتم ربط المصروفات بقائمة الحسابات الرئيسية";

            // لم يتم ربط أقسام المخزون بحسابات الإيرادات الرئيسية
            public const var BLL_CustomError_NotAllowToPostInventoryDepartmentsNotLinkedToRevenuAccount = MaxBLLErrorNumber_Unknown - 44;
            public const var BLL_CustomError_NotAllowToPostInventoryDepartmentsNotLinkedToRevenuAccountDescription = "لايمكن ترحيل فاتورة البيع. لم يتم ربط أقسام المخزون بحسابات الإيرادات الرئيسية";

            // لايمكن تعديل أصناف مستنذ التسوية الجردية بعد الترحيل
            public const var BLL_CustomError_NoAllowToModifiStockAdjustment = MaxBLLErrorNumber_Unknown - 45;
            public const var BLL_CustomError_NoAllowToModifiStockAdjustmentDescription = "لا يمكن (الإضافة - التعديل - الحذف) في مستنذ التسوية الجردية بعد الترحيل ";

            // لايمكن حذف مستنذ التسوية بعد بعد الترحيل
            public const var BLL_CustomError_NoAllowToDeletePostedStockAdjustment = MaxBLLErrorNumber_Unknown - 46;
            public const var BLL_CustomError_NoAllowToDeletePostedStockAdjustmentDescription = "لايمكن حذف عملية التسوية الحالية. لايسمح النظام بحذف عمليات تسوية المخزون المرحلة.";

            // لايمكن تعديل القيود بعد ترحيلها
            public const var BLL_CustomError_NoAllowToModifiJournalEntry = MaxBLLErrorNumber_Unknown - 47;
            public const var BLL_CustomError_NoAllowToModifiJournalEntryDescription = "لا يمكن (الإضافة - التعديل - الحذف) في القيد. تم ترحيل القيد للحسابات...";

            // لايمكن الغاء ترحيل قيد اليومية - لان أصلا غير مرحل
            public const var BLL_CustomError_NotAllowUnPostJournalEntry_IsAlreadyUnPosted = MaxBLLErrorNumber_Unknown - 47;
            public const var BLL_CustomError_NotAllowUnPostJournalEntry_IsAlreadyUnPostedDescription = "لايمكن إلغاء ترحيل قيد اليومية - لانه غير مرحل أصلاً. يمكنك إلغاء الترحيل للقيود المرحلة فقط...";

            // لايمكن الغاء ترحيل قيد اليومية - قيد تم تكوينه من قبل النظام
            public const var BLL_CustomError_NotAllowUnPostJournalEntry_IsCreatedBySystem = MaxBLLErrorNumber_Unknown - 48;
            public const var BLL_CustomError_NotAllowUnPostJournalEntry_IsCreatedBySystemDescription = "لايمكن إلغاء ترحيل قيد اليومية - لايسمح النظام بإلغاء ترحيل القيود المكونة من قبل النظام. يجب التعامل مع المستند الأصلي.";

            // لايمكن ترحيل قيد اليومية - يجب أن يكون إجمالي الحركات المدينة والدائنة اكبر من صفر
            public const var BLL_CustomError_NotAllowPostJournalEntry_CreditOrDebitAmountEquelToZero = MaxBLLErrorNumber_Unknown - 49;
            public const var BLL_CustomError_NotAllowPostJournalEntry_CreditOrDebitAmountEquelToZeroDescription = "لايمكن ترحيل قيد اليومية - يجب أن يكون إجمالي الحركات المدينة والدائنة أكبر من صفر.";

            // لايمكن التعديل في أصناف الفواتير المنشطة
            public const var BLL_CustomError_NotAllowToEditRecalledInvoiceItems = MaxBLLErrorNumber_Unknown - 50;
            public const var BLL_CustomError_NotAllowToEditRecalledInvoiceItemsDescription = "لايسمح بالتعديل في أصناف الفواتير المنشطة .....";

            // لايمكن ترحيل مستند التسوية - تم ترحيلها مسبقاً
            public const var BLL_CustomError_NotAllowPostStockAdjustment_IsAlreadyPosted = MaxBLLErrorNumber_Unknown - 51;
            public const var BLL_CustomError_NotAllowPostStockAdjustment_IsAlreadyPostedDescription = "لايمكن ترحيل مستند التسوية الجردية  - تم ترحيله مسبقاً...";

            // لايمكن ترحيل مستند التسوية الجردية - يوجد خطأ في كميات تاريخ الاصلاحية
            public const var BLL_CustomError_NotAllowPostStockAdjustment_MissedExpireDateQYT = MaxBLLErrorNumber_Unknown - 52;
            public const var BLL_CustomError_NotAllowPostStockAdjustment_MissedExpireDateQYTDescription = "لايمكن ترحيل مستند التسوية الجردية  - يوجد خطأ في كميات تاريخ الصلاحية للاصناف...";

            // لايمكن ترحيل مستند التسوية الجردية - لايمكن ترحيل عمليات عد المخزون بشكل فردي - يجب ترحيل بشكل كامل في عملية واحدة
            public const var BLL_CustomError_NotAllowPostStockAdjustment_NotAllowToPostStockCountOneByOne = MaxBLLErrorNumber_Unknown - 53;
            public const var BLL_CustomError_NotAllowPostStockAdjustment_NotAllowToPostStockCountOneByOneDescription = "لايمكن ترحيل مستند التسوية الجردية - لايمكن ترحيل عمليات عد المخزون بشكل فردي - يجب ترحيلها بشكل كامل في عملية واحدة";

            // لايمكن ترحيل فاتورة البيع - تم ترحيلها مسبقاً
            public const var BLL_CustomError_NotAllowPostSalesInvoice_IsAlreadyPosted = MaxBLLErrorNumber_Unknown - 54;
            public const var BLL_CustomError_NotAllowPostSalesInvoice_IsAlreadyPostedDescription = "لايمكن ترحيل فاتورة البيع للحسابات  - تم ترحيلها مسبقاً...";

            // لايمكن ترحيل فاتورة البيع - الفواتير النقدية لا يتم ترحيلها بشكل فردي للحسابات
            public const var BLL_CustomError_NotAllowPostSalesInvoice_ItCashPayment = MaxBLLErrorNumber_Unknown - 55;
            public const var BLL_CustomError_NotAllowPostSalesInvoice_ItCashPaymentDescription = "لايمكن ترحيل فاتورة البيع للحسابات  - الفواتير النقدية يتم ترحيلها بشكل ضمنى مع ترحيل وردية العمل للحسابات. ولايتم ترحيلها بشكل فردي...";

            // يجب أن تكون الفاتورة الاصلية فاتورة مبيعات
            public const var BLL_CustomError_POS_MustSelectSalesTransactionToCreateRefund = MaxBLLErrorNumber_Unknown - 56;
            public const var BLL_CustomError_POS_MustSelectSalesTransactionToCreateRefundDescription = "يجب تحديد فاتورة مبيعات لكي يمكن إسترجاع الاصناف المدرجة بالفاتورة...";

            // غير مسموح بإلغاء أسم الزبون من الفاتورة في حال كان هناك طريقة دفع بالاجل - علي الحساب لهذه الفاتورة
            public const var BLL_CustomError_Sales_NotAllowToDeleteCustomerFromSalesInvoice_CredtPaymentExist = MaxBLLErrorNumber_Unknown - 57;
            public const var BLL_CustomError_Sales_NotAllowToDeleteCustomerFromSalesInvoice_CredtPaymentExistDescription = " غير مسموح بإلغاء أسم الزبون من الفاتورة في حال كان هناك طريقة دفع بالاجل - علي الحساب لهذه الفاتورة";

            // غير مسموح يتغيير أسم الزبون في فاتورة المبيعات بعد ترحيلها للحسابات
            public const var BLL_CustomError_Sales_NotAllowToChangeCustomerInSalesInvoice_InvoiceIsPosted = MaxBLLErrorNumber_Unknown - 58;
            public const var BLL_CustomError_Sales_NotAllowToChangeCustomerInSalesInvoice_InvoiceIsPostedDescription = "غير مسموح يتغيير أسم الزبون في فاتورة المبيعات بعد ترحيلها للحسابات";

            // غير مسموح يتغيير أسم الزبون في فاتورة المبيعات البيع بالاجل غير مفعل لهذا الزبون
            public const var BLL_CustomError_Sales_NotAllowToChangeCustomerInSalesInvoice_CreditSalesNotActive = MaxBLLErrorNumber_Unknown - 59;
            public const var BLL_CustomError_Sales_NotAllowToChangeCustomerInSalesInvoice_CreditSalesNotActiveDescription = "غير مسموح يتغيير أسم الزبون في فاتورة المبيعات. لم يتم تفعيل البيع بالاجل لهذا الزبون... ";

            // لايمكن البيع للزبون - الحساب غير فعال
            public const var BLL_CustomError_Sales_NotAllowToChangeCustomerInSalesInvoice_AccountNotActive = MaxBLLErrorNumber_Unknown - 60;
            public const var BLL_CustomError_Sales_NotAllowToChangeCustomerInSalesInvoice_AccountNotActiveDescription = "لايمكن البيع لهذا الزبون. حساب الزبون غير مفعل... ";

            // لايمكن التخفيض علي العملية الحالية / تم إغلاق الوردية
            public const var BLL_CustomError_POS_AllowToApplyDiscount_POSShiftIsClosed = MaxBLLErrorNumber_Unknown - 61;
            public const var BLL_CustomError_POS_AllowToApplyDiscount_POSShiftIsClosedDescription = "لايمكن إجراء تخفيضات علي هذه العملية - تم إغلاق جلسة العمل. يمكنك تعديل التخفبض قبل إغلاق الوردية فقط. ";

            // لايمكن التخفيض علي العملية الحالية / توجد اكثر من طريقة دفع للفاتورة
            public const var BLL_CustomError_POS_AllowToApplyDiscount_MoreThanOnePaymentMethods = MaxBLLErrorNumber_Unknown - 62;
            public const var BLL_CustomError_POS_AllowToApplyDiscount_MoreThanOnePaymentMethodsDescription = "لايمكن إجراء تخفيضات علي هذه العملية - تم تنفيذ أكثر من طريقة دفع لهذه الفاتورة ";

            // لايمكن التخفيض في فاتورة المبيعات بعد ترحيلها للحسابات
            public const var BLL_CustomError_Sales_NotAllowToApplyDiscount_InvoiceIsPosted = MaxBLLErrorNumber_Unknown - 63;
            public const var BLL_CustomError_Sales_NotAllowToApplyDiscount_InvoiceIsPostedDescription = "غير مسموح بتعديل التخفيض في فاتورة المبيعات بعد ترحيلها للحسابات";

            // لايمكنك العمل ضمن ورديات العمل التي تم فتحها بواسطة مشغل أخر
            public const var BLL_CustomError_Sales_NotAllowToUseOtherUserShift = MaxBLLErrorNumber_Unknown - 64;
            public const var BLL_CustomError_Sales_NotAllowToUseOtherUserShiftDescription = "لايمكنك العمل ضمن ورديات العمل التي تم فتحها بواسطة مشغل أخر. ليس لديك الصلاحية لذلك. يمكنك مراجعة مدير النظام";

            // لايمكنك إغلاق الورديات التي تم فتحها بواسطة مشغل اخر
            public const var BLL_CustomError_Sales_NotAllowToCloseUserShift = MaxBLLErrorNumber_Unknown - 65;
            public const var BLL_CustomError_Sales_NotAllowToCloseUserShiftDescription = "لايمكنك إقفال ورديات العمل التي تم فتحها بواسطة مشغل أخر. ليس لديك الصلاحية لذلك. يمكنك مراجعة مدير النظام";

            // لايمكنك التعديل في الفواتير التي تم إنشائها بواسطة مشغل اخر
            public const var BLL_CustomError_Sales_NotAllowToEditUserInvoices = MaxBLLErrorNumber_Unknown - 66;
            public const var BLL_CustomError_Sales_NotAllowToEditUserInvoicesDescription = "لايمكنك التعديل في الفواتير التي تم إنشائها بواسطة مشغل أخر. ليس لديك الصلاحية لذلك. يمكنك مراجعة مدير النظام";

            // النظام لايسمح  بتجميد فواتير البيع التي تمت تنفيذ عروض مبيعات عليها
            public const var BLL_CustomError_POS_NotAllowToHoldTransactionWithPromotion = MaxBLLErrorNumber_Unknown - 67;
            public const var BLL_CustomError_POS_NotAllowToHoldTransactionWithPromotionDescription = "النظام لايسمح بتجميد الفواتير بعد تنفيد عروض المبيعات عليها....   ";

            // لايمكن تعديل أصناف مستنذ  نقل المخزون بعد الترحيل
            public const var BLL_CustomError_NoAllowToModifiStockTransfer = MaxBLLErrorNumber_Unknown - 68;
            public const var BLL_CustomError_NoAllowToModifiStockTransferDescription = "لا يمكن (الإضافة - التعديل - الحذف) في مستنذ نقل المخزون بعد الارسال او الاستلام ";

            // لايمكن حذف مستنذ نقل المخزون بعد الترحيل
            public const var BLL_CustomError_NoAllowToDeletePostedStockTransfer = MaxBLLErrorNumber_Unknown - 69;
            public const var BLL_CustomError_NoAllowToDeletePostedStockTransferDescription = "لايمكن حذف عملية نقل المخزون الحالية. لايسمح النظام بحذف نقل المخزون المخزون المرحلة.";

            // لايمكن إرسال أصناف مستند نقل المخزون - تم إرسالها مسبقاً
            public const var BLL_CustomError_NotAllowSendStockTransfer_IsAlreadySent = MaxBLLErrorNumber_Unknown - 70;
            public const var BLL_CustomError_NotAllowSendStockTransfer_IsAlreadySentDescription = "لايمكن إرسال أصناف مستند نقل المخزون المحدد  - تم إرسالها مسبقاً...";

            // لايمكن إرسال أصناف مستند نقل المخزون - لايوجد مخزون كافي في الموقع المحدد
            public const var BLL_CustomError_NotAllowSendStockTransfer_NoStockInSourceLocation = MaxBLLErrorNumber_Unknown - 71;
            public const var BLL_CustomError_NotAllowSendStockTransfer_NoStockInSourceLocationDescription = "لايمكن إرسال أصناف مستند نقل المخزون المحدد  - لايوجد مخزون كافي لإتمام عملية النقل...";

            // لايمكن إرسال أصناف مستند نقل المخزون - يجب إدخال تواريخ الصلاحية للاصناف
            public const var BLL_CustomError_NotAllowSendStockTransfer_MissedExpiryDates = MaxBLLErrorNumber_Unknown - 72;
            public const var BLL_CustomError_NotAllowSendStockTransfer_MissedExpiryDatesDescription = "لايمكن إرسال أصناف مستند نقل المخزون المحدد  - يجب إدخال تاريخ الصلاحية للاصناف...";

            // لايمكن إرسال أصناف مستند نقل المخزون - لايوجد مخزون كافي حسب تاريخ الصلاحية
            public const var BLL_CustomError_NotAllowSendStockTransfer_MissedExpiryDateStock = MaxBLLErrorNumber_Unknown - 73;
            public const var BLL_CustomError_NotAllowSendStockTransfer_MissedExpiryDateStockDescription = "لايمكن إرسال أصناف مستند نقل المخزون المحدد  - لايوجد مخزون كافي من تاريخ الصلاحية المحدد لبعض الاصناف...";

            // لايمكن إرسال أصناف مستند نقل المخزون - يجب إدخال الاصناف اولا
            public const var BLL_CustomError_NotAllowSendStockTransfer_MissedItems = MaxBLLErrorNumber_Unknown - 74;
            public const var BLL_CustomError_NotAllowSendStockTransfer_MissedItemsDescription = "لايمكن إرسال أصناف مستند نقل المخزون المحدد  - يجب إدراج الأصناف قبل عملية الارسال...";

            // لايمكن إستلام أصناف مستند نقل المخزون - تم إستلامها مسبقاً
            public const var BLL_CustomError_NotAllowReceiveStockTransfer_IsAlreadyReceived = MaxBLLErrorNumber_Unknown - 75;
            public const var BLL_CustomError_NotAllowReceiveStockTransfer_IsAlreadyReceivedDescription = "لايمكن إستلام أصناف مستند نقل المخزون المحدد  - تم إستلامها مسبقاً...";

            // لايمكن تنفيذ الاجراء المطلوب . لايوجد جلسة عمل مفتوحة حاليا
            public const var BLL_CustomError_POS_NotAllowToCloseShift_CashLessThanReturn = MaxBLLErrorNumber_Unknown - 76;
            public const var BLL_CustomError_POS_NotAllowToCloseShift_CashLessThanReturnDescription = "لايمكن تنفيذ الاجراء المطلوب / إقفال الوردية. إجمالي قيمة النقدية في الدرج أقل من قيمة المسترجعات النقدية. يجب التاكد أو مراجعة الرصيد الإفتتاحي للوردية";

            // لايمكن حذف الصنف من فاتورة البيع بعد تسليمها
            public const var BLL_CustomError_NoAllowToDeleteSalesInvoiceItem = MaxBLLErrorNumber_Unknown - 77;
            public const var BLL_CustomError_NoAllowToDeleteSalesInvoiceItemDescription = "لا يمكن حذف الأصناف من فاتورة البيع بعد تسليمها للزبون ...";

            // لايمكن تعديل أصناف فاتورة البيع بعد ترحيلها لحساب الزبون
            public const var BLL_CustomError_NoAllowToModifiSalesInvoice = MaxBLLErrorNumber_Unknown - 78;
            public const var BLL_CustomError_NoAllowToModifiSalesInvoiceDescription = "لا يمكن (الإضافة - التعديل - الحذف) في فاتورة البيع أو فاتورة المسترجعات بعد ترحيلها لحساب الزبون";

            // لايمكن تعديل  فاتورة البيع من الإدارة بعد إدخال بيانات الدفع
            public const var BLL_CustomError_NoAllowToModifi_BO_SalesInvoice_PaymentSaved = MaxBLLErrorNumber_Unknown - 79;
            public const var BLL_CustomError_NoAllowToModifi_BO_SalesInvoice_PaymentSavedDescription = "لا يمكن التعديل في فاتورة البيع أو فاتورة المسترجعات بعد حفظ بيانات الدفع" + Constants.vbCrLf + "يمكنك التعديل بعد إلغاء بيانات الدفع...";

            // لايمكن تسليم أصناف فاتورة البيع من الادارة - لايوجد مخزون كافي في الموقع المحدد
            public const var BLL_CustomError_NotAllowDeliverSalesInvoiceItem_NoStockInSourceLocation = MaxBLLErrorNumber_Unknown - 80;
            public const var BLL_CustomError_NotAllowDeliverSalesInvoiceItem_NoStockInSourceLocationDescription = "لايمكن تسليم أصناف فاتورة المبيعات المحددة - لايوجد مخزون كافي لإتمام عملية التسليم...";

            // لايمكن حذف فاتورة البيع من الادارة بعد البدء في إستلام الاصناف
            public const var BLL_CustomError_NoAllowToDelete_BO_SalesInvoice = MaxBLLErrorNumber_Unknown - 81;
            public const var BLL_CustomError_NoAllowToDelete_BO_SalesInvoiceDescription = "لايمكن حذف فاتورة البيع بالكامل بعد البدء في تسليم الاصناف... يمكن حذف الأصناف التي لم يتم تسليمها من الفاتورة";

            // لايمكن إنشاء جلسة عمل جديدة لهذه لنقطة . يوجد حالياً جلسة مفتوحة
            public const var BLL_CustomError_BO_NotAllowToOpenShift_CuseThereAreOpendShift = MaxBLLErrorNumber_Unknown - 82;
            public const var BLL_CustomError_BO_NotAllowToOpenShift_CuseThereAreOpendShiftDescription = "لايمكن فتح أكثر من وردية مبيعات علي نفس الجهاز - يرجى التاكد وإعادة المحاولة";

            // لايمكن إنشاء جلسة عمل جديدة لهذه لنقطة . يوجد حالياً جلسة مفتوحة
            public const var BLL_CustomError_BO_NotAllowToSalesOrRefund_CuseThereAreNoOpendShift = MaxBLLErrorNumber_Unknown - 83;
            public const var BLL_CustomError_BO_NotAllowToSalesOrRefund_CuseThereAreNoOpendShiftDescription = "لاتستطيع البدء في عمليات البيع او الاسترجاع . الا بعد فتح وردية مبيعات جديدة. لاتوجد اي وردية مفتوحة حاليا للعمل عليها";

            // لايمكن تنفيذ الاجراء المطلوب . لايسمح بإغلاق وردية مبيعات تم فتحها بواسطة موظف اخر - لايملك الصلاحية
            public const var BLL_CustomError_POS_NotAllowToCloseShift_OpendByOtherUser = MaxBLLErrorNumber_Unknown - 84;
            public const var BLL_CustomError_POS_NotAllowToCloseShift_OpendByOtherUserDescription = "لايمكن تنفيذ الاجراء المطلوب / إقفال الوردية. لايمكن إغلاق وردية تم فتحها بواسطة موظف اخر. ليس لديك الصلاحية.";

            // لايمكن تعديل  فاتورة البيع من الإدارة الفاتورة مفتوحة من طرف موظف اخر ضمن وردية مبيعات أخرى
            public const var BLL_CustomError_NoAllowToModifi_BO_SalesInvoice_InvoiceIsRelatedToOtherOpenShift = MaxBLLErrorNumber_Unknown - 85;
            public const var BLL_CustomError_NoAllowToModifi_BO_SalesInvoice_InvoiceIsRelatedToOtherOpenShiftDescription = "لايمكن تعديل  فاتورة البيع من الإدارة - الفاتورة مفتوحة من طرف موظف اخر ضمن وردية مبيعات أخرى";

            // لايمكن تعديل  فاتورة البيع من الإدارة الفاتورة مرتبطة بوردية عمل اخرى والوردية تم إلاغلاقها
            public const var BLL_CustomError_NoAllowToModifi_BO_SalesInvoice_InvoiceIsRelatedToOtherClosedShift = MaxBLLErrorNumber_Unknown - 86;
            public const var BLL_CustomError_NoAllowToModifi_BO_SalesInvoice_InvoiceIsRelatedToOtherClosedShiftDescription = "لايمكن تعديل  فاتورة البيع من الإدارة - الفاتورة مدرجة ضمن وردية مبيعات أخرى مغلقة حالياً" + Constants.vbCrLf + "يجب نقل الفاتورة للوردية الحالية لكي تستطيع التعديل عليها...";

            // لايمكن تكوين قيد المبيعات النقدية للوردية- رصيد الخزينة لايغطي قيمة المردودات او العجز بالنقدية
            public const var BLL_CustomError_NotAllowCreatePOSShiftCashJournalEntry_thereIsNoBalance = MaxBLLErrorNumber_Unknown - 87;
            public const var BLL_CustomError_NotAllowCreatePOSShiftCashJournalEntry_thereIsNoBalanceDescription = "لايمكن تكوين قيد المبيعات النقدية للوردية- رصيد الخزينة لايغطي قيمة المردودات او العجز بالنقدية...";

            // لايمكن ترحيل فاتورة بيع او إسترجاع الادارة - فواتير بيع الادارة يتم ترحيلها ضمن إجراء ترحيل الوردية
            public const var BLL_CustomError_NotAllowPostSalesInvoice_It_BO_Invoice = MaxBLLErrorNumber_Unknown - 88;
            public const var BLL_CustomError_NotAllowPostSalesInvoice_It_BO_InvoiceDescription = "لايمكن ترحيل فاتورة البيع للحسابات  - فواتير بيع الادارة ( مبيعات - مردودات ) يتم ترحيلها ضمن إجراء ترحيل الوردية...";

            // لايمكن حذف إيصالات القبض النقذية المنفدة من ضمن ورديات مبيعات غير مرحلة
            public const var BLL_CustomError_NoAllowTodDeleteReceiptVoucherCusePOSShiftNotPosted = MaxBLLErrorNumber_Unknown - 89;
            public const var BLL_CustomError_NoAllowTodDeleteReceiptVoucherCusePOSShiftNotPostedDescription = "لايسمح بحذف سندات القبض النقدية للورديات الغير مرحلة. يمكن حذف سند القبض بعد إتمام عملية ترحيل وردية المبيعات";

            // لايمكن تغيير طريقة الدفع لفاتورة المبيعات بعد ترحيلها للحسابات
            public const var BLL_CustomError_Sales_NotAllowTochangePayment_InvoiceIsPosted = MaxBLLErrorNumber_Unknown - 90;
            public const var BLL_CustomError_Sales_NotAllowTochangePayment_InvoiceIsPostedDescription = "لايمكن تعديل طريقة الدفع في فاتورة المبيعات بعد ترحيلها للحسابات";

            // لايمكن  تغيير طريقة الدفع للفاتورة الحالية / تم إغلاق الوردية
            public const var BLL_CustomError_POS_AllowTochangePayment_POSShiftIsClosed = MaxBLLErrorNumber_Unknown - 91;
            public const var BLL_CustomError_POS_AllowTochangePayment_POSShiftIsClosedDescription = "لايمكن تعديل طريقة الدفع علي هذه الفاتورة المحددة - تم إغلاق جلسة العمل. يمكنك تغيير طريقة الدفع فقط قبل إغلاق الوردية فقط. ";

            // لايمكن ترحيل فاتورة بيع او إسترجاع نقاط البيع التي لديها اكثر من طريقة دفع - يتم ترحيلها ضمن إجراء ترحيل الوردية
            public const var BLL_CustomError_NotAllowPostSalesInvoice_It_POS_Invoice_withMultiPayments = MaxBLLErrorNumber_Unknown - 92;
            public const var BLL_CustomError_NotAllowPostSalesInvoice_It_POS_Invoice_withMultiPaymentsDescription = "لايمكن ترحيل فاتورة البيع للحسابات  - فواتير نقاط البيع POS  ( مبيعات - مردودات ) التي لديها اكثر من طريقة دفع . يتم ترحيلها ضمن إجراء ترحيل الوردية...";


            // *********************************************************************************************************************************************
            // مجموعة الاخطا التي تخص الفروع
            // *********************************************************************************************************************************************
            // لم يتم التحصل علي بيانات الفرع
            public const var BLL_CusError_SysPermissions_NotAllowToLoadLocalBranchData = MaxBLLErrorNumber_Unknown - 397;
            public const var BLL_CusError_SysPermissions_NotAllowToLoadLocalBranchDataDescription = " لم يتمكن النظام من الحصول علي بيانات الفرع الحالي ... يرجى التأكد وإعادة المحاولة ";

            // لايمكن إضافة الأصناف الجديدة في الفروع
            public const var BLL_CusError_SysPermissions_NotAllowToCreateProductAtBranchs = MaxBLLErrorNumber_Unknown - 398;
            public const var BLL_CusError_SysPermissions_NotAllowToCreateProductAtBranchsDescription = " لايمكن إضافة الأصناف الجديدة من خلال الفروع . يجب أن تتم العملية في المخزن / الإدارة الرئيسية ";

            // لايمكن تنفيذ هذا الإجراء من خلال الفروع
            public const var BLL_CusError_SysPermissions_ThisActionNotAllowedAtBranchs = MaxBLLErrorNumber_Unknown - 399;
            public const var BLL_CusError_SysPermissions_ThisActionNotAllowedAtBranchsDescription = " لايمكن تنفيذ هذا الإجراء من خلال الفروع . يجب أن تتم العملية في الإدارة الرئيسية ";

            // *********************************************************************************************************************************************
            // مجموعة الاخطا التي تخص الفروع
            // *********************************************************************************************************************************************

            // حدث خطأ عند الإتصال بالمعدات الطرفية لنقطة البيع
            public const var BLL_CustomError_HardwareConnectionError = MaxBLLErrorNumber_Unknown - 497;
            public const var BLL_CustomError_HardwareConnectionErrorDescription = "حدث خطأ عند محاولة الإتصال بالمعدات الطرفية لنقطة البيع ... درج النقدية أو شاشة الاسعار أو القاري";


            // لايمكن تسجيل الدخول للمستخدم - يوجد خطا في كلمة المرور او أسم المستخدم
            public const var BLL_UserError_LoginFaild = MaxBLLErrorNumber_Unknown - 498;
            public const var BLL_UserError_LoginFaildDescription = "لايمكن تسجيل الدخول، يوجد خطأ ببيانات الدخول، يرجي التأكد أو الاتصال بمسؤول النظام...";

            // لايمكن تنفيذ الإجراء المطلوب بناء علي الصلاحيات
            public const var BLL_CusError_SysPermissions_NotAllowToRunnigThisAction = MaxBLLErrorNumber_Unknown - 499;
            public const var BLL_CusError_SysPermissions_NotAllowToRunnigThisActionDescription = "لايمكن تنفيذ الإجراء المطلوب وذلك بناء علي الصلاحيات الممنوحة لك. يرجى التواصل مع مسؤول النظام للمزيد من المعلومات...";

            // تم إلغاء العملية من قبل المستخدم
            public const var BLL_CusError_OperationCanceledByUser = MaxBLLErrorNumber_Unknown - 500;
            public const var BLL_CusError_OperationCanceledByUserDescription = "تم إلغاء العملية من قبل المستخدم،،،";

    }
}
