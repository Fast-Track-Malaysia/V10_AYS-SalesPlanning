using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Data;

namespace FT_ADDON.AYS
{
    class Sysform_APDO
    {
        public static void processRightClickEventbefore(SAPbouiCOM.Form oForm, ref SAPbouiCOM.ContextMenuInfo pVal, ref bool BubbleEvent)
        {
            try
            {
            }
            catch (Exception ex)
            {
                FT_ADDON.SAP.SBOApplication.MessageBox(ex.Message, 1, "Ok", "", "");
            }
        }
        public static void processRightClickEventafter(SAPbouiCOM.Form oForm, ref SAPbouiCOM.ContextMenuInfo pVal)
        {
        }
        public static void processItemEventbefore(SAPbouiCOM.Form oForm, ref SAPbouiCOM.ItemEvent pVal, ref bool BubbleEvent)
        {
            try
            {
            }
            catch (Exception ex)
            {
                FT_ADDON.SAP.SBOApplication.MessageBox(ex.Message, 1, "Ok", "", "");
            }
        }
        public static void processItemEventafter(SAPbouiCOM.Form oForm, ref SAPbouiCOM.ItemEvent pVal)
        {
            try
            {
                switch (pVal.EventType)
                {
                    case SAPbouiCOM.BoEventTypes.et_DOUBLE_CLICK:
                        if (pVal.ItemUID == "38")
                        {
                            if (oForm.Mode == SAPbouiCOM.BoFormMode.fm_OK_MODE)
                            {
                                if (pVal.Row >= 0)
                                {
                                    int docentry = int.Parse(oForm.DataSources.DBDataSources.Item("PDN1").GetValue("DOCENTRY", pVal.Row - 1).ToString());
                                    int linenum = int.Parse(oForm.DataSources.DBDataSources.Item("PDN1").GetValue("LINENUM", pVal.Row - 1).ToString());
                                    if (pVal.ColUID == "U_SPDOC")
                                    {
                                        InitForm.DOPTM(oForm.UniqueID, docentry, linenum, pVal.Row, "FT_APDOSP", "");
                                    }
                                }
                            }
                        }
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                FT_ADDON.SAP.SBOApplication.MessageBox(ex.Message, 1, "Ok", "", "");
            }
        }
        public static void processMenuEventbefore(SAPbouiCOM.Form oForm, ref SAPbouiCOM.MenuEvent pVal, ref bool BubbleEvent)
        {
            return;
        }
        public static void processMenuEventafter(SAPbouiCOM.Form oForm, ref SAPbouiCOM.MenuEvent pVal)
        {
            return;
        }
    }
}
