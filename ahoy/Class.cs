
//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------


namespace ahoy
{

using System;
    using System.Collections.Generic;
    
public partial class Class
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Class()
    {

        this.Employee = new HashSet<Employee>();

    }


    public int ClassID { get; set; }

    public string className { get; set; }

    public int PermissionID { get; set; }

    public decimal salary { get; set; }

    public decimal overtimeSalary { get; set; }



    public virtual Permission Permission { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Employee> Employee { get; set; }

}

}
