//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace XOX.CRM.Lib.DBContext
{
    using System;
    using System.Collections.Generic;
    
    public partial class XOX_T_ORDER_AUDIT
    {
        public long ROW_ID { get; set; }
        public Nullable<long> CREATED_BY { get; set; }
        public Nullable<System.DateTime> CREATED { get; set; }
        public Nullable<long> LAST_UPD_BY { get; set; }
        public Nullable<System.DateTime> LAST_UPD { get; set; }
        public Nullable<long> ACCNT_ID { get; set; }
        public Nullable<long> ORDER_ID { get; set; }
        public string MSISDN { get; set; }
        public string PLAN { get; set; }
        public string CATEGORY { get; set; }
        public string SIM_SERIAL_NUMBER { get; set; }
        public Nullable<System.DateTime> SUBMISSION_DT { get; set; }
        public string SALUTATION { get; set; }
        public string NAME { get; set; }
        public Nullable<System.DateTime> DOB { get; set; }
        public Nullable<int> GENDER { get; set; }
        public string ID_TYPE { get; set; }
        public string ID_NUM { get; set; }
        public string MOTHER_MAIDEN_NAM { get; set; }
        public string EMAIL { get; set; }
        public string MOBILE_NO { get; set; }
        public string NATIONALITY { get; set; }
        public string RACE { get; set; }
        public string PREF_LANG { get; set; }
        public string BANK_NAME { get; set; }
        public string BANK_ACCNT_NUMBER { get; set; }
        public Nullable<bool> ITEMISED_BILLING { get; set; }
        public string ADDR_1 { get; set; }
        public string ADDR_2 { get; set; }
        public string CITY { get; set; }
        public string STATE { get; set; }
        public string POSTCODE { get; set; }
        public string COUNTRY { get; set; }
        public string BILL_ADDR_1 { get; set; }
        public string BILL_ADDR_2 { get; set; }
        public string BILL_CITY { get; set; }
        public string BILL_STATE { get; set; }
        public string BILL_POSTCODE { get; set; }
        public string BILL_COUNTRY { get; set; }
        public string BILL_CARD_TYPE { get; set; }
        public string BILL_CARD_NUMBER { get; set; }
        public string BILL_ACCNT_NAME { get; set; }
        public string BILL_BANK_ISSUER { get; set; }
        public Nullable<int> BILL_EXPIRY_YEAR { get; set; }
        public Nullable<int> BILL_EXPIRY_MONTH { get; set; }
        public Nullable<bool> BILL_THIRD_PARTY { get; set; }
        public string MSISDN_SUPPLINE { get; set; }
    }
}