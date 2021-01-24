# Project1
## Project 1 - Airline reservation 
- Programming task is to design and develop a console application for an airline company that issues boarding passes for an aircraft with 40 seats. Need to design and develop a C# object-oriented solution for this task.
- The application requires a class called Passenger that contains passenger information and allocates a seat number based on seat availability to each passenger. The data attributes for the passenger class includes, but not limited to, a security number, departure time, departure gate and other attributes that are required to issue a boarding pass.
- Need to construct methods to obtain all information necessary from the passengers.
- Application must meet all the following requirements and handle all run time errors. 
1.	Passenger names should not be longer than 5 characters.
The passenger name (i.e. first and last) should be trimmed or truncated to 5 characters if the name provided is greater than 5 characters.
2.	Security number on boarding pass should be a random number generated between 30,000 and 999,999.					
3.	Each seat number must only be allocated to one passenger. For example, if the seat number 14 is allocated to a passenger, then the seat number 14 should not be available for the any other passenger.							
4.	The application will continually accept passenger requests; the passenger attributes may vary from passenger to passenger (e.g. each passenger is a new object). Your application should also be able to handle a number of the passengers in a single invoice. For example, Mr John Smith may have bought two tickets for his wife and himself in single invoice. This means the application should be able to accept and allocate adjacent seats for the two passengers.															
5.	If all seats have been allocated to passengers, the application should not accept any more requests. Notify the Airline Assistant.						
6.	Date and Time should be printed when passenger entries are completed.
(e.g., system time 24 April 2019).					
7.	You should have a method (part of the Passenger class) to list all the passenger names followed by their seat numbers and the security numbers once the flight is closed.
8.	After check-in is completed, boarding passes must be displayed in a tabular format for each passenger.  					
9.	Create a method to display the available seats to the Airline Assistant on request anytime. This method should be part of the Passenger class and will be invoked from the Main() method.

## Project 2 - Cashless pay system
- Programming task is to design and develop a console application for a company for providing cashless pay to their employees of 100. Need to design and develop a C# object-oriented solution for this task.
