using System;

// Define the IQuittable interface with a Quit() method
interface IQuittable
{
    void Quit();
}

// Create an Employee class that inherits from IQuittable
class Employee : IQuittable
{
    // Implement the Quit() method
    public void Quit()
    {
        Console.WriteLine("Employee has quit their job.");
        // You can add more logic here if needed
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create an instance of Employee
        Employee employee = new Employee();

        // Use polymorphism to create an object of type IQuittable
        IQuittable quittableEmployee = employee;

        // Call the Quit() method on the IQuittable object
        quittableEmployee.Quit();

        // Output:
        // Employee has quit their job.
    }
}
