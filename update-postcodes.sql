-- Update postcodes for existing customers
WITH PostcodeData AS (
    SELECT CustID,
    CASE (CustID - 1) % 40
        -- London postcodes
        WHEN 0 THEN 'E1 1AB'
        WHEN 1 THEN 'E2 2CD'
        WHEN 2 THEN 'N1 3EF'
        WHEN 3 THEN 'N2 4GH'
        WHEN 4 THEN 'SW1 5IJ'
        WHEN 5 THEN 'SW2 6KL'
        WHEN 6 THEN 'SW3 7MN'
        WHEN 7 THEN 'E7 8OP'
        WHEN 8 THEN 'E8 9QR'
        WHEN 9 THEN 'N7 1ST'
        -- South postcodes
        WHEN 10 THEN 'PO1 2UV'
        WHEN 11 THEN 'PO2 3WX'
        WHEN 12 THEN 'SO14 4YZ'
        WHEN 13 THEN 'SO15 5AB'
        WHEN 14 THEN 'SO16 6CD'
        WHEN 15 THEN 'PO3 7EF'
        WHEN 16 THEN 'PO4 8GH'
        WHEN 17 THEN 'SO17 9IJ'
        -- South East postcodes
        WHEN 18 THEN 'ME1 1KL'
        WHEN 19 THEN 'ME2 2MN'
        WHEN 20 THEN 'CT1 3OP'
        WHEN 21 THEN 'CT2 4QR'
        WHEN 22 THEN 'TN1 5ST'
        WHEN 23 THEN 'TN2 6UV'
        WHEN 24 THEN 'BN1 7WX'
        WHEN 25 THEN 'BN2 8YZ'
        -- South West postcodes
        WHEN 26 THEN 'BS1 1AB'
        WHEN 27 THEN 'BS2 2CD'
        WHEN 28 THEN 'EX1 3EF'
        WHEN 29 THEN 'EX2 4GH'
        WHEN 30 THEN 'PL1 5IJ'
        WHEN 31 THEN 'PL2 6KL'
        WHEN 32 THEN 'TR1 7MN'
        WHEN 33 THEN 'TR2 8OP'
        WHEN 34 THEN 'BS3 9QR'
        WHEN 35 THEN 'EX3 1ST'
        WHEN 36 THEN 'PL3 2UV'
        WHEN 37 THEN 'TR3 3WX'
        WHEN 38 THEN 'BS4 4YZ'
        WHEN 39 THEN 'EX4 5AB'
    END AS NewPostcode
    FROM Customers
)
UPDATE Customers
SET Postcode = pd.NewPostcode
FROM Customers c
JOIN PostcodeData pd ON c.CustID = pd.CustID;
