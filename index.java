import java.util.Random;
import java.swing.JLabel;
import java.awt.event.Keyevent;
import javax.swing.Jwindow;
import java.awt.AWTExtension;
import java.awt.Robot;
import java.awt.Toolkit;
import java.awt.Dimension;

public class Fish {
  private final Dimension screenSize = Toolkit.getDefaultToolkit().getScreenSize();
  private final int height = (int) screenSize.getHeight();
  private final int width = (int) screenSize.getWidth();
  private final Random Rande = new Random();
  
  
  public void BlockAll() throws AWTExtension
  {
      Robot _robot = new Robot();
	  _robot.keyPress(KeyEvent.VK_0);
	  _robot.moveMove(Randm.nextInt(width),Random.nextInt(height));
  }
  public void Popup()
  {
	  Jwindow window = new Jwindow();
	  JLabel label = new JLabel(text:":)",JLabel.CENTER);
	  window.add(label)
	  window.setSize(width:150,height:50);
	  window.setLocation(Randm.nextInt(width), Randm.nextInt(height));
	  window.setVisible(true);
  }
  public static void main(String[] args) throws AWTExtension, InterruptedException{
	  Fish fv = new Fish();
	  
	  while(true)
	  {
		  fv.BlockAll();
		  fv.Popup();
	  }
  }