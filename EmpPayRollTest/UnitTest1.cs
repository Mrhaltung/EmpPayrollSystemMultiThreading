using Microsoft.VisualStudio.TestTools.UnitTesting;
using EmpPayrollSystem;
using System.Collections.Generic;

namespace EmpPayrollTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Given10EmpWhenAddedToListShouldMatchEmpEntries()
        {
            List<EmpDetails> employeeDetails = new List<EmpDetails>();
            employeeDetails.Add(new EmpDetails(EmployeeID: 1, EmployeeName: "Bru", PhoneNumber: "9999999", Address: "xyz", Department: "Hr", Gender: 'M', BasicPay: 3433, Deduction: 544, TaxablePay: 5456, Tax: 4565, NetPay: 5665, City: "bANGLORE", Country: "India"));
            employeeDetails.Add(new EmpDetails(EmployeeID: 2, EmployeeName: "Bce", PhoneNumber: "9999999", Address: "xyz", Department: "Hr", Gender: 'M', BasicPay: 3433, Deduction: 544, TaxablePay: 5456, Tax: 4565, NetPay: 5665, City: "bANGLORE", Country: "India"));
            employeeDetails.Add(new EmpDetails(EmployeeID: 3, EmployeeName: "Buce", PhoneNumber: "9999999", Address: "xyz", Department: "Hr", Gender: 'M', BasicPay: 3433, Deduction: 544, TaxablePay: 5456, Tax: 4565, NetPay: 5665, City: "bANGLORE", Country: "India"));
            employeeDetails.Add(new EmpDetails(EmployeeID: 4, EmployeeName: "race", PhoneNumber: "9999999", Address: "xyz", Department: "Hr", Gender: 'M', BasicPay: 3433, Deduction: 544, TaxablePay: 5456, Tax: 4565, NetPay: 5665, City: "bANGLORE", Country: "India"));
            employeeDetails.Add(new EmpDetails(EmployeeID: 5, EmployeeName: "use", PhoneNumber: "9999999", Address: "xyz", Department: "Hr", Gender: 'M', BasicPay: 3433, Deduction: 544, TaxablePay: 5456, Tax: 4565, NetPay: 5665, City: "bANGLORE", Country: "India"));
            employeeDetails.Add(new EmpDetails(EmployeeID: 6, EmployeeName: "Bruse", PhoneNumber: "9999999", Address: "xyz", Department: "Hr", Gender: 'M', BasicPay: 3433, Deduction: 544, TaxablePay: 5456, Tax: 4565, NetPay: 5665, City: "bANGLORE", Country: "India"));
            employeeDetails.Add(new EmpDetails(EmployeeID: 7, EmployeeName: "Brure", PhoneNumber: "9999999", Address: "xyz", Department: "Hr", Gender: 'M', BasicPay: 3433, Deduction: 544, TaxablePay: 5456, Tax: 4565, NetPay: 5665, City: "bANGLORE", Country: "India"));
            employeeDetails.Add(new EmpDetails(EmployeeID: 8, EmployeeName: "Bruee", PhoneNumber: "9999999", Address: "xyz", Department: "Hr", Gender: 'M', BasicPay: 3433, Deduction: 544, TaxablePay: 5456, Tax: 4565, NetPay: 5665, City: "bANGLORE", Country: "India"));
            employeeDetails.Add(new EmpDetails(EmployeeID: 9, EmployeeName: "Brua", PhoneNumber: "9999999", Address: "xyz", Department: "Hr", Gender: 'M', BasicPay: 3433, Deduction: 544, TaxablePay: 5456, Tax: 4565, NetPay: 5665, City: "bANGLORE", Country: "India"));
            employeeDetails.Add(new EmpDetails(EmployeeID: 10, EmployeeName: "use", PhoneNumber: "9999999", Address: "xyz", Department: "Hr", Gender: 'M', BasicPay: 3433, Deduction: 544, TaxablePay: 5456, Tax: 4565, NetPay: 5665, City: "bANGLORE", Country: "India"));


            EmployeePayRollOperation employeePayRollOperation = new EmployeePayRollOperation();
            employeePayRollOperation.addEmployeeToPayRoll(employeeDetails);
            //employeePayRollOperation.addEmployeeToPayRollWithThread(employeeDetails);
        }
    }
}
