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
    
    public partial class XOX_T_ACCNT
    {
        public XOX_T_ACCNT()
        {
            this.XOX_T_BILL_PAYMENT = new HashSet<XOX_T_BILL_PAYMENT>();
            this.XOX_T_ACCNT_REFUND = new HashSet<XOX_T_ACCNT_REFUND>();
        }
    
        public long ROW_ID { get; set; }
        public Nullable<long> CREATED_BY { get; set; }
        public Nullable<System.DateTime> CREATED { get; set; }
        public Nullable<long> LAST_UPD_BY { get; set; }
        public Nullable<System.DateTime> LAST_UPD { get; set; }
        public string NAME { get; set; }
        public string LOC { get; set; }
        public Nullable<System.DateTime> BIRTH_DT { get; set; }
        public string SALUTATION { get; set; }
        public string NATIONALITY { get; set; }
        public string ID_TYPE { get; set; }
        public string ID_NUM { get; set; }
        public string CUST_TYPE_CD { get; set; }
        public string ACCNT_TYPE_CD { get; set; }
        public string INTEGRATION_ID { get; set; }
        public string CUSTOMER_NUM { get; set; }
        public string ACCNT_STATUS { get; set; }
        public Nullable<long> ADDR_ID { get; set; }
        public string EMAIL_ADDR { get; set; }
        public string MOBILE_NO { get; set; }
        public string HOUSE_NO { get; set; }
        public string OFFICE_NO { get; set; }
        public string FAX_NO { get; set; }
        public string MOTHER_MAIDEN_NAME { get; set; }
        public string BILL_CYCLE { get; set; }
        public string BILL_CURR { get; set; }
        public string BILL_LANG { get; set; }
        public string PAYMENT_METHOD { get; set; }
        public string BANK_NAME { get; set; }
        public Nullable<System.DateTime> CUST_SINCE { get; set; }
        public Nullable<long> PAR_ACCNT_ID { get; set; }
        public Nullable<long> MASTER_ACCNT_ID { get; set; }
        public string CONTACT_NAME { get; set; }
        public string BUSINESS_TYPE { get; set; }
        public string WEBSITE_URL { get; set; }
        public Nullable<int> EMP_NO { get; set; }
        public string VIP_FLG { get; set; }
        public string BILL_ACCNT_NUM { get; set; }
        public string BILL_ACCNT_NAME { get; set; }
        public string BILL_COMP_NAME { get; set; }
        public string SALES_CD { get; set; }
        public string DEALER_CODE { get; set; }
        public string SIM_SERIAL_NUMBER { get; set; }
        public Nullable<long> CUST_USER_ID { get; set; }
        public string ACCNT_SUB_STATUS { get; set; }
        public Nullable<decimal> CREDIT_LIMIT { get; set; }
        public string MSISDN { get; set; }
        public Nullable<int> GENDER { get; set; }
        public string PREFERRED_LANG { get; set; }
        public string RACE { get; set; }
        public string SPONSOR_PERSONNEL { get; set; }
        public string BANK_ACC_NUM { get; set; }
        public string BANK_ISSUER { get; set; }
        public Nullable<bool> BANK_THIRD_PARTY { get; set; }
        public Nullable<int> BANK_EXPIRY_YEAR { get; set; }
        public Nullable<int> BANK_EXPIRY_MONTH { get; set; }
        public string BILL_CARD_TYPE { get; set; }
        public Nullable<System.DateTime> TERMINATION_DT { get; set; }
        public Nullable<int> GRADE_SCORE { get; set; }
        public string BANK_ACCNT_NAME { get; set; }
    
        public virtual ICollection<XOX_T_BILL_PAYMENT> XOX_T_BILL_PAYMENT { get; set; }
        public virtual ICollection<XOX_T_ACCNT_REFUND> XOX_T_ACCNT_REFUND { get; set; }
    }
}
