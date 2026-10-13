import javax.swing.*;
import java.awt.*;
import java.text.NumberFormat;


//task 3-4
public class TipTaxTotal extends JFrame{
    private JTextField foodChargeTextField;

    private JLabel tipLabel;
    private JLabel taxLabel;
    private JLabel totalLabel;

    private JButton calculateButton;
    private JButton exitButton;

    public TipTaxTotal()
{
    setTitle("Tip, Tax, and Total");
    setSize(400, 250);
    setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
    setLocationRelativeTo(null);

    calculateButton.addActionListener(e ->
);
}

//task 5
//create the controls
foodChargeTextField = new JTextField(10);

tipLabel = new JLabel("");
taxLabel = new JLabel("");
totalLabel = new JLabel("");

calculateButton = new JButton("Calculate");
exitButton = new JButton("Exit");


//create the panel
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

//task 6
calculateButton.addActionListener(e ->
{
    double foodCharge;
    double tip;
    double tax;
    double total;

    foodCharge =
        Double.parseDouble(
            foodChargeTextField.getText()
        );

    tip = foodCharge * 0.15;
    tax = foodCharge * 0.07;
    total = foodCharge + tip + tax;

    NumberFormat currency =
        NumberFormat.getCurrencyInstance();

    tipLabel.setText(currency.format(tip));
    taxLabel.setText(currency.format(tax));
    totalLabel.setText(currency.format(total));
});

exitButton.addActionListener(e ->
{
    System.exit(0);
});

//task 8: main method
public static void main(String[] args)
{
    SwingUtilities.invokeLater(() ->
    {
        new TipTaxTotal()
            .setVisible(true);
    });
}

}