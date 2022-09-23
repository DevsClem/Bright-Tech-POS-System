-- phpMyAdmin SQL Dump
-- version 4.8.3
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 16, 2019 at 04:56 AM
-- Server version: 10.1.37-MariaDB
-- PHP Version: 7.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db_pos_project`
--

-- --------------------------------------------------------

--
-- Stand-in structure for view `joincustomer`
-- (See below for the actual view)
--
CREATE TABLE `joincustomer` (
`ID` int(8)
,`Customer Name` varchar(255)
,`Contact` varchar(255)
,`Gender` varchar(55)
,`Address` text
);

-- --------------------------------------------------------

--
-- Stand-in structure for view `joinproducts`
-- (See below for the actual view)
--
CREATE TABLE `joinproducts` (
`ID` int(8)
,`Name` varchar(255)
,`Category` varchar(255)
,`Brand` varchar(55)
,`Price` double(10,2)
,`Quantity` int(50)
,`Description` text
);

-- --------------------------------------------------------

--
-- Stand-in structure for view `joinsales`
-- (See below for the actual view)
--
CREATE TABLE `joinsales` (
`ID` int(8)
,`Customer` varchar(255)
,`Payment Method` varchar(255)
,`Employee Name` varchar(255)
,`Date Time` datetime
,`Net Total` double(10,2)
);

-- --------------------------------------------------------

--
-- Stand-in structure for view `joinsalesdetails`
-- (See below for the actual view)
--
CREATE TABLE `joinsalesdetails` (
`Sales ID` int(8)
,`Product ID` int(8)
,`Product Title` varchar(255)
,`Description` text
,`Quantity` int(12)
,`Price` double(10,2)
,`Sub Total` double(19,2)
,`Discount` double(10,2)
);

-- --------------------------------------------------------

--
-- Stand-in structure for view `joinstockin`
-- (See below for the actual view)
--
CREATE TABLE `joinstockin` (
`ID` int(8)
,`Supply Date` date
,`Employee Name` varchar(255)
,`Supplier` varchar(255)
);

-- --------------------------------------------------------

--
-- Stand-in structure for view `joinstockindetails`
-- (See below for the actual view)
--
CREATE TABLE `joinstockindetails` (
`Supply ID` int(8)
,`Product ID` int(8)
,`Product Title` varchar(255)
,`Quantity` int(12)
,`Price` double(10,2)
);

-- --------------------------------------------------------

--
-- Stand-in structure for view `joinstockout`
-- (See below for the actual view)
--
CREATE TABLE `joinstockout` (
`ID` int(8)
,`Date` date
,`Product ID` int(8)
,`Product Name` varchar(255)
,`Employee Name` varchar(255)
,`Quantity` int(10)
,`Remarks` text
);

-- --------------------------------------------------------

--
-- Table structure for table `tbl_admin`
--

CREATE TABLE `tbl_admin` (
  `Admin_ID` int(8) NOT NULL,
  `Employee_ID` int(8) NOT NULL,
  `Username` varchar(255) NOT NULL,
  `Password` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_admin`
--

INSERT INTO `tbl_admin` (`Admin_ID`, `Employee_ID`, `Username`, `Password`) VALUES
(1, 1, 'Admin', 'admin123');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_brand`
--

CREATE TABLE `tbl_brand` (
  `Brand_ID` int(8) NOT NULL,
  `Brand_Title` varchar(55) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_brand`
--

INSERT INTO `tbl_brand` (`Brand_ID`, `Brand_Title`) VALUES
(1, 'Asus'),
(2, 'Intel');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_category`
--

CREATE TABLE `tbl_category` (
  `Category_ID` int(8) NOT NULL,
  `Category_Title` varchar(255) NOT NULL,
  `Category_Description` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_category`
--

INSERT INTO `tbl_category` (`Category_ID`, `Category_Title`, `Category_Description`) VALUES
(1, 'CPU', '100 Core'),
(2, 'Graphics Card', '8GB'),
(3, 'Mouse', '8000 DPI');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_customer`
--

CREATE TABLE `tbl_customer` (
  `Customer_ID` int(8) NOT NULL,
  `Customer_Name` varchar(255) NOT NULL,
  `Customer_Contact` varchar(255) NOT NULL,
  `Gender_ID` int(8) NOT NULL,
  `Customer_Address` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_customer`
--

INSERT INTO `tbl_customer` (`Customer_ID`, `Customer_Name`, `Customer_Contact`, `Gender_ID`, `Customer_Address`) VALUES
(1, 'Clement Narciso', '09434468759', 1, 'Maa Davao City'),
(2, 'Mirage', '0944563453', 2, 'Cabantian');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_employee`
--

CREATE TABLE `tbl_employee` (
  `Employee_ID` int(8) NOT NULL,
  `Employee_Name` varchar(255) NOT NULL,
  `Employee_Contact` varchar(255) NOT NULL,
  `Gender_ID` int(8) NOT NULL,
  `Employee_Birthdate` date NOT NULL,
  `Employee_Address` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_employee`
--

INSERT INTO `tbl_employee` (`Employee_ID`, `Employee_Name`, `Employee_Contact`, `Gender_ID`, `Employee_Birthdate`, `Employee_Address`) VALUES
(1, 'Clement Narciso', '094344468759', 1, '1997-05-12', 'Maa Davao City'),
(2, 'Lifeline Main', '09434468752', 2, '1991-07-15', 'Matina Davao');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_gender`
--

CREATE TABLE `tbl_gender` (
  `Gender_ID` int(8) NOT NULL,
  `Gender_Title` varchar(55) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_gender`
--

INSERT INTO `tbl_gender` (`Gender_ID`, `Gender_Title`) VALUES
(1, 'Male'),
(2, 'Female');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_payment`
--

CREATE TABLE `tbl_payment` (
  `Payment_ID` int(8) NOT NULL,
  `Payment_Method` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_payment`
--

INSERT INTO `tbl_payment` (`Payment_ID`, `Payment_Method`) VALUES
(1, 'Cash');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_product`
--

CREATE TABLE `tbl_product` (
  `Product_ID` int(8) NOT NULL,
  `Product_Title` varchar(255) NOT NULL,
  `Category_ID` int(8) NOT NULL,
  `Brand_ID` int(8) NOT NULL,
  `Product_Price` double(10,2) NOT NULL,
  `Quantity` int(50) NOT NULL,
  `Product_Description` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_product`
--

INSERT INTO `tbl_product` (`Product_ID`, `Product_Title`, `Category_ID`, `Brand_ID`, `Product_Price`, `Quantity`, `Product_Description`) VALUES
(1, 'Intel i9 Processor', 1, 1, 8000.00, 434, '16 cores processor'),
(2, 'Gtx 1060', 2, 1, 12000.00, 38, '8 GB'),
(3, 'Intel i7 Processor', 1, 1, 500.00, 57, '7th Gen Processor'),
(4, 'GtX 1050', 1, 1, 8000.50, 12, '4GB VRAM');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_sales`
--

CREATE TABLE `tbl_sales` (
  `Sales_ID` int(8) NOT NULL,
  `Customer_ID` int(8) NOT NULL,
  `Payment_ID` int(8) NOT NULL,
  `Employee_ID` int(8) NOT NULL,
  `Sales_Date` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `Net_Total` double(10,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_sales`
--

INSERT INTO `tbl_sales` (`Sales_ID`, `Customer_ID`, `Payment_ID`, `Employee_ID`, `Sales_Date`, `Net_Total`) VALUES
(1, 1, 1, 1, '2019-05-16 10:06:08', 86400.00);

-- --------------------------------------------------------

--
-- Table structure for table `tbl_sales_details`
--

CREATE TABLE `tbl_sales_details` (
  `Sales_ID` int(8) NOT NULL,
  `Product_ID` int(8) NOT NULL,
  `Quantity` int(12) NOT NULL,
  `Sub_Total` double(10,2) NOT NULL,
  `Discount` double(10,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_sales_details`
--

INSERT INTO `tbl_sales_details` (`Sales_ID`, `Product_ID`, `Quantity`, `Sub_Total`, `Discount`) VALUES
(1, 1, 5, 40000.00, 1600.00),
(1, 2, 4, 48000.00, 0.00);

-- --------------------------------------------------------

--
-- Table structure for table `tbl_stockout`
--

CREATE TABLE `tbl_stockout` (
  `Stockout_ID` int(8) NOT NULL,
  `Stockout_Date` date NOT NULL,
  `Admin_ID` int(8) NOT NULL,
  `Product_ID` int(8) NOT NULL,
  `Quantity` int(10) NOT NULL,
  `Remarks` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tbl_supplier`
--

CREATE TABLE `tbl_supplier` (
  `Supplier_ID` int(8) NOT NULL,
  `Supplier_Name` varchar(255) NOT NULL,
  `Supplier_Contact` varchar(255) NOT NULL,
  `Supplier_Address` text NOT NULL,
  `Supplier_Email` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_supplier`
--

INSERT INTO `tbl_supplier` (`Supplier_ID`, `Supplier_Name`, `Supplier_Contact`, `Supplier_Address`, `Supplier_Email`) VALUES
(1, 'Davao Computer', '0942445986', 'Nicasio Torres Street', 'dcomp@yahoo.com'),
(2, 'Manila Computers', '0943445678', 'Manila Manila', 'manilacomputer@yahoo.com'),
(3, 'Digos Suppliers', '0943452342', 'Digos', 'DigosSuppliers@gmail.com');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_supply`
--

CREATE TABLE `tbl_supply` (
  `Supply_ID` int(8) NOT NULL,
  `Supply_Date` date NOT NULL,
  `Admin_ID` int(8) NOT NULL,
  `Supplier_ID` int(8) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_supply`
--

INSERT INTO `tbl_supply` (`Supply_ID`, `Supply_Date`, `Admin_ID`, `Supplier_ID`) VALUES
(1, '2019-05-11', 1, 2);

-- --------------------------------------------------------

--
-- Table structure for table `tbl_supply_details`
--

CREATE TABLE `tbl_supply_details` (
  `Supply_ID` int(8) NOT NULL,
  `Product_ID` int(8) NOT NULL,
  `Quantity` int(12) NOT NULL,
  `Price` double(10,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_supply_details`
--

INSERT INTO `tbl_supply_details` (`Supply_ID`, `Product_ID`, `Quantity`, `Price`) VALUES
(1, 3, 50, 100000.00);

-- --------------------------------------------------------

--
-- Structure for view `joincustomer`
--
DROP TABLE IF EXISTS `joincustomer`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `joincustomer`  AS  select `c`.`Customer_ID` AS `ID`,`c`.`Customer_Name` AS `Customer Name`,`c`.`Customer_Contact` AS `Contact`,`g`.`Gender_Title` AS `Gender`,`c`.`Customer_Address` AS `Address` from (`tbl_customer` `c` join `tbl_gender` `g` on((`c`.`Gender_ID` = `g`.`Gender_ID`))) order by `c`.`Customer_ID` ;

-- --------------------------------------------------------

--
-- Structure for view `joinproducts`
--
DROP TABLE IF EXISTS `joinproducts`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `joinproducts`  AS  select `p`.`Product_ID` AS `ID`,`p`.`Product_Title` AS `Name`,`c`.`Category_Title` AS `Category`,`b`.`Brand_Title` AS `Brand`,`p`.`Product_Price` AS `Price`,`p`.`Quantity` AS `Quantity`,`p`.`Product_Description` AS `Description` from ((`tbl_product` `p` join `tbl_category` `c` on((`p`.`Category_ID` = `c`.`Category_ID`))) join `tbl_brand` `b` on((`p`.`Brand_ID` = `b`.`Brand_ID`))) order by `p`.`Product_ID` ;

-- --------------------------------------------------------

--
-- Structure for view `joinsales`
--
DROP TABLE IF EXISTS `joinsales`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `joinsales`  AS  select `s`.`Sales_ID` AS `ID`,`c`.`Customer_Name` AS `Customer`,`p`.`Payment_Method` AS `Payment Method`,`e`.`Employee_Name` AS `Employee Name`,`s`.`Sales_Date` AS `Date Time`,`s`.`Net_Total` AS `Net Total` from (((`tbl_sales` `s` join `tbl_customer` `c` on((`s`.`Customer_ID` = `c`.`Customer_ID`))) join `tbl_payment` `p` on((`s`.`Payment_ID` = `p`.`Payment_ID`))) join `tbl_employee` `e` on((`s`.`Employee_ID` = `e`.`Employee_ID`))) order by `s`.`Sales_ID` ;

-- --------------------------------------------------------

--
-- Structure for view `joinsalesdetails`
--
DROP TABLE IF EXISTS `joinsalesdetails`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `joinsalesdetails`  AS  select `s`.`Sales_ID` AS `Sales ID`,`p`.`Product_ID` AS `Product ID`,`p`.`Product_Title` AS `Product Title`,`p`.`Product_Description` AS `Description`,`s`.`Quantity` AS `Quantity`,`p`.`Product_Price` AS `Price`,(`s`.`Quantity` * `p`.`Product_Price`) AS `Sub Total`,`s`.`Discount` AS `Discount` from (`tbl_sales_details` `s` join `tbl_product` `p` on((`s`.`Product_ID` = `p`.`Product_ID`))) order by `s`.`Sales_ID` ;

-- --------------------------------------------------------

--
-- Structure for view `joinstockin`
--
DROP TABLE IF EXISTS `joinstockin`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `joinstockin`  AS  select `s`.`Supply_ID` AS `ID`,`s`.`Supply_Date` AS `Supply Date`,`e`.`Employee_Name` AS `Employee Name`,`ss`.`Supplier_Name` AS `Supplier` from (((`tbl_supply` `s` join `tbl_admin` `a` on((`s`.`Admin_ID` = `a`.`Admin_ID`))) join `tbl_employee` `e` on((`a`.`Employee_ID` = `e`.`Employee_ID`))) join `tbl_supplier` `ss` on((`ss`.`Supplier_ID` = `s`.`Supplier_ID`))) order by `s`.`Supply_ID` ;

-- --------------------------------------------------------

--
-- Structure for view `joinstockindetails`
--
DROP TABLE IF EXISTS `joinstockindetails`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `joinstockindetails`  AS  select `s`.`Supply_ID` AS `Supply ID`,`p`.`Product_ID` AS `Product ID`,`p`.`Product_Title` AS `Product Title`,`s`.`Quantity` AS `Quantity`,`s`.`Price` AS `Price` from (`tbl_supply_details` `s` join `tbl_product` `p` on((`s`.`Product_ID` = `p`.`Product_ID`))) order by `s`.`Supply_ID` ;

-- --------------------------------------------------------

--
-- Structure for view `joinstockout`
--
DROP TABLE IF EXISTS `joinstockout`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `joinstockout`  AS  select `s`.`Stockout_ID` AS `ID`,`s`.`Stockout_Date` AS `Date`,`p`.`Product_ID` AS `Product ID`,`p`.`Product_Title` AS `Product Name`,`e`.`Employee_Name` AS `Employee Name`,`s`.`Quantity` AS `Quantity`,`s`.`Remarks` AS `Remarks` from (((`tbl_stockout` `s` join `tbl_admin` `a` on((`s`.`Admin_ID` = `a`.`Admin_ID`))) join `tbl_employee` `e` on((`e`.`Employee_ID` = `e`.`Employee_ID`))) join `tbl_product` `p` on((`s`.`Product_ID` = `p`.`Product_ID`))) order by `s`.`Stockout_ID` ;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tbl_admin`
--
ALTER TABLE `tbl_admin`
  ADD PRIMARY KEY (`Admin_ID`),
  ADD KEY `Employee_ID` (`Employee_ID`);

--
-- Indexes for table `tbl_brand`
--
ALTER TABLE `tbl_brand`
  ADD PRIMARY KEY (`Brand_ID`);

--
-- Indexes for table `tbl_category`
--
ALTER TABLE `tbl_category`
  ADD PRIMARY KEY (`Category_ID`);

--
-- Indexes for table `tbl_customer`
--
ALTER TABLE `tbl_customer`
  ADD PRIMARY KEY (`Customer_ID`),
  ADD KEY `Gender_ID` (`Gender_ID`);

--
-- Indexes for table `tbl_employee`
--
ALTER TABLE `tbl_employee`
  ADD PRIMARY KEY (`Employee_ID`),
  ADD KEY `Gender_ID` (`Gender_ID`);

--
-- Indexes for table `tbl_gender`
--
ALTER TABLE `tbl_gender`
  ADD PRIMARY KEY (`Gender_ID`);

--
-- Indexes for table `tbl_payment`
--
ALTER TABLE `tbl_payment`
  ADD PRIMARY KEY (`Payment_ID`);

--
-- Indexes for table `tbl_product`
--
ALTER TABLE `tbl_product`
  ADD PRIMARY KEY (`Product_ID`),
  ADD KEY `Brand_ID` (`Brand_ID`),
  ADD KEY `Category_ID` (`Category_ID`);

--
-- Indexes for table `tbl_sales`
--
ALTER TABLE `tbl_sales`
  ADD PRIMARY KEY (`Sales_ID`),
  ADD KEY `Customer_ID` (`Customer_ID`),
  ADD KEY `Employee_ID` (`Employee_ID`),
  ADD KEY `Payment_ID` (`Payment_ID`);

--
-- Indexes for table `tbl_sales_details`
--
ALTER TABLE `tbl_sales_details`
  ADD PRIMARY KEY (`Sales_ID`,`Product_ID`),
  ADD KEY `Product_ID` (`Product_ID`);

--
-- Indexes for table `tbl_stockout`
--
ALTER TABLE `tbl_stockout`
  ADD PRIMARY KEY (`Stockout_ID`),
  ADD KEY `Admin_ID` (`Admin_ID`),
  ADD KEY `Product_ID` (`Product_ID`);

--
-- Indexes for table `tbl_supplier`
--
ALTER TABLE `tbl_supplier`
  ADD PRIMARY KEY (`Supplier_ID`);

--
-- Indexes for table `tbl_supply`
--
ALTER TABLE `tbl_supply`
  ADD PRIMARY KEY (`Supply_ID`),
  ADD KEY `Admin_ID` (`Admin_ID`),
  ADD KEY `Supplier_ID` (`Supplier_ID`);

--
-- Indexes for table `tbl_supply_details`
--
ALTER TABLE `tbl_supply_details`
  ADD PRIMARY KEY (`Supply_ID`,`Product_ID`),
  ADD KEY `Product_ID` (`Product_ID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tbl_admin`
--
ALTER TABLE `tbl_admin`
  MODIFY `Admin_ID` int(8) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `tbl_brand`
--
ALTER TABLE `tbl_brand`
  MODIFY `Brand_ID` int(8) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `tbl_category`
--
ALTER TABLE `tbl_category`
  MODIFY `Category_ID` int(8) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `tbl_customer`
--
ALTER TABLE `tbl_customer`
  MODIFY `Customer_ID` int(8) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `tbl_employee`
--
ALTER TABLE `tbl_employee`
  MODIFY `Employee_ID` int(8) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `tbl_gender`
--
ALTER TABLE `tbl_gender`
  MODIFY `Gender_ID` int(8) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `tbl_payment`
--
ALTER TABLE `tbl_payment`
  MODIFY `Payment_ID` int(8) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `tbl_product`
--
ALTER TABLE `tbl_product`
  MODIFY `Product_ID` int(8) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `tbl_sales`
--
ALTER TABLE `tbl_sales`
  MODIFY `Sales_ID` int(8) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `tbl_stockout`
--
ALTER TABLE `tbl_stockout`
  MODIFY `Stockout_ID` int(8) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `tbl_supplier`
--
ALTER TABLE `tbl_supplier`
  MODIFY `Supplier_ID` int(8) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `tbl_supply`
--
ALTER TABLE `tbl_supply`
  MODIFY `Supply_ID` int(8) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `tbl_admin`
--
ALTER TABLE `tbl_admin`
  ADD CONSTRAINT `tbl_admin_ibfk_1` FOREIGN KEY (`Employee_ID`) REFERENCES `tbl_employee` (`Employee_ID`);

--
-- Constraints for table `tbl_customer`
--
ALTER TABLE `tbl_customer`
  ADD CONSTRAINT `tbl_customer_ibfk_1` FOREIGN KEY (`Gender_ID`) REFERENCES `tbl_gender` (`Gender_ID`);

--
-- Constraints for table `tbl_employee`
--
ALTER TABLE `tbl_employee`
  ADD CONSTRAINT `tbl_employee_ibfk_1` FOREIGN KEY (`Gender_ID`) REFERENCES `tbl_gender` (`Gender_ID`);

--
-- Constraints for table `tbl_product`
--
ALTER TABLE `tbl_product`
  ADD CONSTRAINT `tbl_product_ibfk_1` FOREIGN KEY (`Brand_ID`) REFERENCES `tbl_brand` (`Brand_ID`),
  ADD CONSTRAINT `tbl_product_ibfk_2` FOREIGN KEY (`Category_ID`) REFERENCES `tbl_category` (`Category_ID`);

--
-- Constraints for table `tbl_sales`
--
ALTER TABLE `tbl_sales`
  ADD CONSTRAINT `tbl_sales_ibfk_1` FOREIGN KEY (`Customer_ID`) REFERENCES `tbl_customer` (`Customer_ID`),
  ADD CONSTRAINT `tbl_sales_ibfk_2` FOREIGN KEY (`Employee_ID`) REFERENCES `tbl_employee` (`Employee_ID`),
  ADD CONSTRAINT `tbl_sales_ibfk_3` FOREIGN KEY (`Payment_ID`) REFERENCES `tbl_payment` (`Payment_ID`);

--
-- Constraints for table `tbl_sales_details`
--
ALTER TABLE `tbl_sales_details`
  ADD CONSTRAINT `tbl_sales_details_ibfk_1` FOREIGN KEY (`Sales_ID`) REFERENCES `tbl_sales` (`Sales_ID`),
  ADD CONSTRAINT `tbl_sales_details_ibfk_2` FOREIGN KEY (`Product_ID`) REFERENCES `tbl_product` (`Product_ID`);

--
-- Constraints for table `tbl_stockout`
--
ALTER TABLE `tbl_stockout`
  ADD CONSTRAINT `tbl_stockout_ibfk_1` FOREIGN KEY (`Admin_ID`) REFERENCES `tbl_admin` (`Admin_ID`),
  ADD CONSTRAINT `tbl_stockout_ibfk_2` FOREIGN KEY (`Product_ID`) REFERENCES `tbl_product` (`Product_ID`);

--
-- Constraints for table `tbl_supply`
--
ALTER TABLE `tbl_supply`
  ADD CONSTRAINT `tbl_supply_ibfk_1` FOREIGN KEY (`Admin_ID`) REFERENCES `tbl_admin` (`Admin_ID`),
  ADD CONSTRAINT `tbl_supply_ibfk_2` FOREIGN KEY (`Supplier_ID`) REFERENCES `tbl_supplier` (`Supplier_ID`);

--
-- Constraints for table `tbl_supply_details`
--
ALTER TABLE `tbl_supply_details`
  ADD CONSTRAINT `tbl_supply_details_ibfk_1` FOREIGN KEY (`Supply_ID`) REFERENCES `tbl_supply` (`Supply_ID`),
  ADD CONSTRAINT `tbl_supply_details_ibfk_2` FOREIGN KEY (`Product_ID`) REFERENCES `tbl_product` (`Product_ID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
