//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Dictionary.Models
{
    using System;
    
    public partial class GetWordsByUserId_Result
    {
        public int WordId { get; set; }
        public string sWord { get; set; }
        public string sDefinition { get; set; }
        public string sExample { get; set; }
        public string OriginalLanguage { get; set; }
        public string sWordtype { get; set; }
        public Nullable<int> Id_Language_trans { get; set; }
        public string TranslationLanguage { get; set; }
        public Nullable<System.DateTime> dDatetime { get; set; }
        public Nullable<int> HistoryUserId { get; set; }
    }
}