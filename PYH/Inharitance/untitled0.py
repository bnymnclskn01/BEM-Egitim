# -*- coding: utf-8 -*-
"""
Created on Sun Nov  6 15:10:37 2022

@author: ever_
"""

class Person(object):
 
    def __init__(self, name, idnumber):
        self.name = name
        self.idnumber = idnumber
 
    def display(self):
        print(self.name)
        print(self.idnumber)
 
# child class
 
 
class Employee(Person):
    def __init__(self, name, idnumber, salary, post):
        self.salary = salary
        self.post = post
 
        Person.__init__(self, name, idnumber)
 
 
a = Employee('Ömer Talha Aktaş', 886012, 200000, "Yazılım Geliştirici")
 
a.display()