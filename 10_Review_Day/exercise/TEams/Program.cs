﻿using System;
using System.Collections.Generic;

namespace TEams
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Run();
        }

        List<Department> departments = new List<Department>();
        private void Run()
        {
            // create some departments
            CreateDepartments();

            // print each department by name
            PrintDepartments();

            // create employees
            CreateEmployees();

            // give Angie a 10% raise, she is doing a great job!


            // print all employees
            PrintEmployees();

            // create the TEams project
            CreateTeamsProject();

            // create the Marketing Landing Page Project
            CreateLandingPageProject();

            // print each project name and the total number of employees on the project
            PrintProjectsReport();
        }

        /**
         * Create departments and add them to the collection of departments
         */
        private void CreateDepartments()
        {
            Department marketing = new Department(1, "Marketing");
            Department sales = new Department(2, "Sales");
            Department engineering = new Department(3, "Engineering");
            departments.Add(marketing);
            departments.Add(sales);
            departments.Add(engineering);
        }

        /**
         * Print out each department in the collection.
         */
        private void PrintDepartments()
        {
            Console.WriteLine("------------- DEPARTMENTS ------------------------------");
            foreach (Department item in departments)
            {
                Console.WriteLine(item.Name);
            }

        }

        /**
         * Create employees and add them to the collection of employees
         */
        private void CreateEmployees()
        {

        }

        /**
         * Print out each employee in the collection.
         */
        private void PrintEmployees()
        {
            Console.WriteLine("\n------------- EMPLOYEES ------------------------------");

        }

        /**
         * Create the 'TEams' project.
         */
        private void CreateTeamsProject()
        {

        }

        /**
         * Create the 'Marketing Landing Page' project.
         */
        private void CreateLandingPageProject()
        {

        }

        /**
         * Print out each project in the collection.
         */
        private void PrintProjectsReport()
        {
            Console.WriteLine("\n------------- PROJECTS ------------------------------");

        }
    }
}
