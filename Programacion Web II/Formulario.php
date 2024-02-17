<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <h1>Please complete the form below</h1>
    <form action="">
        <h2>Personal Information</h2>
        Name: <input type="text" name="name">
        <br>
        <br>
        Last Name: <input type="text" name="last-name">
        <br>
        <br>
        Email: <input type="email" name="email">
        <br>
        <br>
        <h2>Credit card Information</h2>
        CardHolder: <input type="text" name="cardholder">
        <br>
        <br>
        Card Number: <input type="text" name="card-number">
        <br>
        <br>
        CVV2: <input type="text" name="cvv2">
        <br>
        <br>
        Exp. Date: <input type="date" name="exp-date">
        <br>
        <br>
        <h2>Billing Addres</h2>
        Street Address: <input type="text" name="street-address">
        <br>
        <br>
        City: <input type="text" name="city">
        <br>
        <br>
        State: 
        <select name="state" id="state">
            <option value="None" selected>None</option>
            <option value="Active">Active</option>
            <option value="Inactive">Inactive</option>
        </select>
        <br>
        <br>
        ZIP: <input type="text" name="zip">
        <br>
        <br>
        Country: 
        <select name="country" id="country">
            <option value="United States" selected>United States</option>
            <option value="Bolivia">Bolivia</option>
            <option value="Argentina">Argentina</option>
        </select>
        <br>
        <br>
        Phone: <input type="text" name="phone">
        <br>
        <br>
        Security Code: <input type="text" name="security-code">
        <br>
        <br>
        <input type="submit" value="ENVIAR">
    </form>        
</body>
<?php
if ($_SERVER["REQUEST_METHOD"] == "POST") {
    $name = $_POST["name"];
    $lastName = $_POST["last-name"];
    $email = $_POST["email"];
    $cardHolder = $_POST["cardholder"];
    $cardNumber = $_POST["card-number"];
    $cvv2 = $_POST["cvv2"];
    $expDate = $_POST["exp-date"];
    $streetAddress = $_POST["street-address"];
    $city = $_POST["city"];
    $state = $_POST["state"];
    $zip = $_POST["zip"];
    $country = $_POST["country"];
    $phone = $_POST["phone"];
    $securityCode = $_POST["security-code"];
    echo "<h2>Thank you for submitting the form!</h2>";
    echo "<p>Name: " . $name . "</p>";
    echo "<p>Last Name: " . $lastName . "</p>";
    echo "<p>Email: " . $email . "</p>";
    echo "<p>Card Holder: " . $cardHolder . "</p>";
    echo "<p>Card Number: " . $cardNumber . "</p>";
    echo "<p>CVV2: " . $cvv2 . "</p>";
    echo "<p>Expiration Date: " . $expDate . "</p>";
    echo "<p>Street Address: " . $streetAddress . "</p>";
    echo "<p>City: " . $city . "</p>";
    echo "<p>State: " . $state . "</p>";
    echo "<p>ZIP: " . $zip . "</p>";
    echo "<p>Country: " . $country . "</p>";
    echo "<p>Phone: " . $phone . "</p>";
    echo "<p>Security Code: " . $securityCode . "</p>";
    exit();
}
?>
</html>