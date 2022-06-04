Welcome to Budget Planner

BudgetPlanner#2.1

V2.1

#Contents of this ReadMe File:

  * Instructions on how to install and use the app
  * Instructions on how to open and start the application
  * The hardware equipment needed
  * The software requirement
  * Description of program
  * Contributions
  * Authors and Acknowledgments
  * Segments of the application
  * FAQ’s – Frequently Asked Questions
  * Differences between Task 1 and Task 2
  * References

---------------------------------------------------------------------------------------------

#These are the instructions needed to be followed on how to install and use the app

Before using this application, ensure that the following steps are completed:

Step 1: Ensure all files are unzipped

Step 2: Ensure that your .NETFramework is installed and on version V4.7.2
#If this is not installed, proceed to the following link to download your .NETFramework
https://visualstudio.microsoft.com/vs/

Step 3: Follow the guide lines on how to install .NETFramework and complete it

---------------------------------------------------------------------------------------------

#Once the above steps have been completed, please continue to follow the next steps

Step 1: Extract the folder “ST10084661_TASK2_POE_AyuriSingh” to your specific file location

Step 2: Locate and click on the folder “ST10084661_TASK2_POE_AyuriSingh”

Step 3: Locate and click on the folder called “ST10084661_BudgetPlannerV2.1”

Step 4: Click on the application called “ST10084661_Task2_POE” and your application should run

----------------------------------------------------------------------------------------------

#Build – Hardware Equipment

Specifications of machine:

Intel(R) Core(TM) CPU
Minimum 4gb ram
Intel graphics
Windows 7 or above

-----------------------------------------------------------------------------------------------

#Software Requirement

.NETFramwork v7.2

-----------------------------------------------------------------------------------------------

#Description

This program is a Budget Planning tool which allows you to determine in advance 
whether you will have enough money to do the things you need to do or would like to do.   
This program requires you to enter your expenses and your monthly income. 
the user's monthly income.

------------------------------------------------------------------------------------------------

#Contributions

Contributions are welcome. They can be sent via email to ST10084661@vcconnect.edu.za

------------------------------------------------------------------------------------------------

#Author and Acknowledgments

Author: A Singh

------------------------------------------------------------------------------------------------

#Built With: Visual Studios 2022

The application has the following segments: 
1.Enter all your expenses: gross monthly income, monthly tax, groceries, water and lights, travel 
costs, cell phone and telephone, and any other expenses.

2.You will be able to choose between renting or buying a property. If you choose renting a property, 
you will enter your monthly rental amount. If you choose to buy a property, you will be required to 
enter the following values for a home loan (purchase price of the property, total deposit, interest 
rate, and the number of months to repay)

3.You will be able to decide if you would like to buy a vehicle. If you select to buy a vehicle, you 
will be required to enter the following values: model and make, purchase price, total deposit, interest 
rate, estimated insurance premium.

4.Once all values have been entered, the application will do the following: 
	
	*If you chose to buy a property: the application will calculate the monthly home loan repayment. If the home 
	loan repayment is more than a third than the users gross monthly income, the application will alert the user 
	that the approval of the home loan is unlikely. 
	
	*If the user chose to buy a car, the application will calculate the total monthly cost of buying the car.

5.	The application will then display all your expenses listed, your available money leftover, and total cost of car.

--------------------------------------------------------------------------------------------------------------------------

#FAQ’s

Q: Do I need to use a comma ( , ) or a full stop ( . ) when entering my interest rate?
A: Please use a comma ( , ) and keep your interest rate as a percentage.

Q: When entering my values, do I need to enter the absolute correct value with decimal places?
A: Yes. Please be as accurate as you can!

Q: How many “other expenses” can I have?
A: Please enter the total sum of your other expenses.

-------------------------------------------------------------------------------------------------------------------------------

#Differences between Task 1 and Task 2

In my first program, I had 3 classes (Program.cs, Prompting.cs, and Expenses.cs). I had two methods (in my Prompting.cs class, 
my method was: promptUser(), and in my Expenses.cs class my method was: Calculator()).  My only abstract class was Expenses.cs. 
My coding methods were unstructured, poor and messy. There was no flow and hardly any advanced methods.  

In my new and updated program, I have 11 classes: 

*Program.cs 
*Car.cs 
*DisplayExpenses.cs 
*Expenses.cs 
*FinalAvailableMoney.cs 
*HomeLoan.cs 
*LoadingScreen.cs 
*OrganisingData.cs 
*Rent.cs 
*UserInput.cs  
*ClearAll.cs 

I have used many advanced methods such as an expenses list, 3 delegates, a kanban board, abstract methods, inheritance, exception 
handling, and constructors.  

-------------------------------------------------------------------------------------------------------------------------------------

#REFERENCES

--  W3schools.com. 2022. C# Abstraction. [online] Available at: 
    <https://www.w3schools.com/cs/cs_abstract.php#:~:text=To%20access%20the%20abstract%20class,override%20the%20base%20class%20method.> 
    [Accessed 8 May 2022].
               
 --  Siyavula.com. 2022. 9.4 Calculations using simple and compound interest | Finance and growth | Siyavula. [online] Available at: 
     <https://www.siyavula.com/read/maths/grade-10/finance-and-growth/09-finance-and-growth-03> [Accessed 8 May 2022].

---------------------------------------------------------------------------------------------------------------------------------
