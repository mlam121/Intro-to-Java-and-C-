import javax.swing.*;
import java.awt.*;
import java.text.NumberFormat;

public class TipTaxTotal extends JFrame {
//instance variables
    private JTextField foodChargeTextField;

    private JLabel tipLabel;
    private JLabel taxLabel;
    private JLabel totalLabel;

    private JButton calculateButton;
    private JButton exitButton;
//constructor
    public TipTaxTotal(){
        setTitle("Tip, Tax, and Total");
        setSize(400, 250);
        setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        setLocationRelativeTo(null);

//controls
    foodChargeTextField = new JTextField(10);

    tipLabel = new JLabel("");
    taxLabel = new JLabel("");
    totalLabel = new JLabel("");

    calculateButton = new JButton("Calculate");
    exitButton = new JButton("Exit");

//create panel
    JPanel panel = new JPanel();
    panel.setLayout(new GridLayout(5, 2, 5, 5));

    //add controls to panel
    panel.add(new JLabel("Food Charge:"));
    panel.add(foodChargeTextField);

    panel.add(new JLabel("Tip:"));
    panel.add(tipLabel);

    panel.add(new JLabel("Tax:"));
    panel.add(taxLabel);

    panel.add(new JLabel("Total:"));
    panel.add(totalLabel);

    panel.add(calculateButton);
    panel.add(exitButton);
    
//add panel to window
    add(panel);

//calculate button action listener
calculateButton.addActionListener(e ->
{
//declare variables
double foodCharge;
double tip;
double tax;
double total;

//user input
foodCharge =
    Double.parseDouble(
        foodChargeTextField.getText()
    );

    //perform calculations
tip = foodCharge * 0.15;
tax = foodCharge * 0.07;
total = foodCharge + tip + tax;

//create currency formatter
NumberFormat currency =
    NumberFormat.getCurrencyInstance();

//display results
tipLabel.setText(currency.format(tip));
taxLabel.setText(currency.format(tax));
totalLabel.setText(currency.format(total));
        }); //closes calculate button action listener

//exit button action listener
exitButton.addActionListener(e ->
{
    System.exit(0);
});//closes exit button action listener
    }//closes constructor

public static void main(String[] args)
{
    SwingUtilities.invokeLater(() ->
    {
        new TipTaxTotal()
            .setVisible(true);
        });
    }//close main method
}//closes class