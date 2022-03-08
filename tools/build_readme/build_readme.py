# This script runs through the directories and builds a readme file with a list of clickable leetcode URLs to help users browse what is out there

import os

print ("# CSharp Solutions ")

base_url = 'https://leetcode.com/problems/'
for dirpath, dirs, files in os.walk("../../leetcode-csharp/"):  
            for dir in dirs:
               if (dir not in ('bin','obj','Debug','netcoreapp3.1','.vs','v17','leetcode-csharp','DesignTimeBuild')):
                       print('- [' + dir + '](' + base_url + dir + ')')