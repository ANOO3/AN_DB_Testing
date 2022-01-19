#To replicate any of the files , in our case preferably index.java or index.cs
from sys import argv
import os
script = argv
name = str(script[0])
cmd = ‘start index.java’
os.system(cmd)
os.mkdir(‘clone’)
os.system(r”copy index.java clone”)
os.system(r”copy ” + name + ” clone”)
#we strongly hate python and everything that has to do with it.
