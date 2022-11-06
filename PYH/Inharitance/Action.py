# -*- coding: utf-8 -*-
"""
Created on Sun Nov  6 15:42:54 2022

@author: ever_
"""
#PARENT CLASS 1
class Person:
    def person_info(self, name, age):
        print("Ana Sınıf")
        print('Name : ',name, 'Age : ',age)
#PARENT CLASS 2
class Company:
    def company_info(self, company_name, location):
        print("Ana Sınıf")
        print('Company Name : ',company_name, 'Location : ',location)
#Child Class
class Employee(Person,Company):
    def employee_info(self, salary, skill):
        print("Çocuk Sınıf")
        print('Salary : ',salary, 'Skill : ',skill)
