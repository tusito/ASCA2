// ======================================
// Author: Roberto Garcia
// Email:  roberto.garcia@transmaquila.com
// ======================================

using DAL.Core;
using System.Collections.Generic;
// ======================================
// Author: Roberto Garcia
// Email:  roberto.garcia@transmaquila.com
// ======================================

namespace DAL.Models
{
    public class Loan
    {
        public int Id { get; set; }

        public int AccountId { get; set; }
        public Account Account { get; set; }

        public decimal LoandAmount { get; set; }
        public decimal InterestRate { get; set; }
        public Periodicity InterestRatePeriodicity { get; set; }
        public int Term { get; set; }
        public Periodicity TermPeriodicity { get; set; }
        public ICollection<LoanDetail> ContributorsCollection { get; set; }
    }
}


//  Loan amount  $2,500.00 
//  Interest rate   5.709% 
//  Term	10 
//  Term Periodicity    Weekly
//  Interest rate Periodicity   Weekly
//  Start date of loan	01/24/2018
//  payment	335 


//  Pmt.No.Payment      Date        Beginning Balance  Scheduled Payment   Total Payment   Principal   Interest    Ending Balance  Cumulative Interest
								
//        1     	01/27/2018	        $2,500.00 	      $335.00 	           $335.00 	     $192.28     $142.72 	 $2,307.72 	         $142.72 
//        2     	02/03/2018	        $2,307.72 	      $335.00 	           $335.00 	     $203.26     $131.74 	 $2,104.47 	         $274.47 
//        3     	02/10/2018	        $2,104.47 	      $335.00 	           $335.00 	     $214.86     $120.14 	 $1,889.61 	         $394.61 
//        4     	02/17/2018	        $1,889.61 	      $335.00 	           $335.00 	     $227.13     $107.87 	 $1,662.48 	         $502.48 
//        5     	02/24/2018	        $1,662.48 	      $335.00 	           $335.00 	     $240.09      $94.91 	 $1,422.39 	         $597.39 
//        6     	03/03/2018	        $1,422.39 	      $335.00 	           $335.00 	     $253.80      $81.20 	 $1,168.59 	         $678.59 
//        7     	03/10/2018	        $1,168.59 	      $335.00 	           $335.00 	     $268.29      $66.71 	   $900.30 	         $745.30 
//        8     	03/17/2018	          $900.30 	      $335.00 	           $335.00 	     $283.60      $51.40 	   $616.70 	         $796.70 
//        9     	03/24/2018	          $616.70 	      $335.00 	           $335.00 	     $299.79      $35.21 	   $316.91 	         $831.91 
//        10	    03/31/2018	          $316.91 	      $335.00 	           $335.00 	     $316.91      $18.09 	   $(0.00)	         $850.00 
