# Farmlink - Agricultural E-Commerce Platform

## 🌾 Project Overview

Farmlink is a comprehensive agricultural e-commerce platform developed as a Windows Forms application using C# and .NET Framework. It connects farmers, buyers, agents, and administrators in a unified marketplace ecosystem to streamline agricultural product trading and distribution.

## 🚀 Features

### Multi-User System
- **Customer/Buyer Interface**: Browse products, add to cart, place orders, track order status
- **Seller Interface**: List products, manage inventory, view sales, handle orders
- **Agent Interface**: Facilitate transactions, manage commissions, coordinate deliveries
- **Admin Interface**: User management, order oversight, payment processing, platform administration

### Core Functionality
- **Product Management**: Add, edit, and manage agricultural products with images
- **Shopping Cart**: Add products to cart, modify quantities, proceed to checkout
- **Order Management**: Place orders, track order status, manage deliveries
- **Payment System**: Multiple payment methods including Cash on Delivery (COD)
- **User Authentication**: Secure login system with role-based access control
- **Notification System**: Real-time notifications for order updates and system events
- **Search & Filter**: Search products by name and filter results

### Business Features
- **Commission System**: Agent commission tracking and payment distribution
- **Delivery Management**: Order tracking from placement to delivery
- **Platform Revenue**: Automated platform fee calculation and collection
- **User Approval System**: Admin approval required for new user registrations
- **Order History**: Comprehensive order tracking and history management

## 🛠️ Technical Stack

- **Framework**: .NET Framework 4.7.2
- **Language**: C# (Windows Forms Application)
- **Database**: Microsoft SQL Server (Local SQL Express)
- **ORM**: ADO.NET with custom database helper class
- **UI Framework**: Windows Forms with custom controls
- **Additional Libraries**: 
  - CefSharp (for embedded browser functionality)
  - EntityFramework 6.4.4
  - System.Data.SqlClient

## 📁 Project Structure

```
Farmlink/
├── Forms/
│   ├── intro.cs                 # Welcome/Landing page
│   ├── login.cs                 # User authentication
│   ├── signin.cs                # User registration
│   ├── B-Home.cs                # Buyer dashboard
│   ├── s_home.cs                # Seller dashboard
│   ├── agent_home.cs            # Agent dashboard
│   └── A_home.cs                # Admin dashboard
├── UserControls/
│   ├── ordercard.cs             # Product display card
│   ├── bcart.cs                 # Shopping cart item
│   ├── B_order_stat.cs          # Order status tracking
│   ├── a_orders.cs              # Admin order management
│   ├── a_payment.cs             # Admin payment management
│   └── a-manageuser.cs          # User management
├── Data/
│   ├── db.cs                    # Database helper class
│   ├── FarmlinkDataSet.xsd      # Typed dataset
│   └── farmlinkDB.bacpac        # Database backup
├── Resources/
│   ├── images/                  # Product and UI images
│   └── Properties/              # Application settings
└── Documentation/
    └── ER.uxf                   # Entity Relationship diagram
```

## 🗄️ Database Schema

The application uses a SQL Server database with the following main tables:

- **userinfo**: User accounts and profiles
- **product**: Agricultural products catalog
- **cart**: Shopping cart items
- **order**: Order transactions
- **orderhistory**: Order tracking and history
- **agent**: Agent information and commissions
- **delivery**: Delivery management
- **pay_history**: Payment and commission records
- **withdraw**: Agent withdrawal requests

## 🔧 Installation & Setup

### Prerequisites
- Windows 10/11
- Visual Studio 2019 or later
- SQL Server Express LocalDB or SQL Server
- .NET Framework 4.7.2 or higher

### Database Setup
1. Install SQL Server Express with the instance name `MUBIN\SQLEXPRESS`
2. Restore the database from `Data/farmlinkDB.bacpac`
3. Update the connection string in `db.cs` if using a different SQL Server instance:
   ```csharp
   string constring = "Data Source = YOUR_SERVER_NAME; Initial Catalog = Farmlink; Integrated Security = True;";
   ```

### Application Setup
1. Clone or download the project
2. Open `Farmlink.sln` in Visual Studio
3. Restore NuGet packages:
   - CefSharp.Common
   - EntityFramework
   - Other dependencies will be restored automatically
4. Build the solution (Build → Build Solution)
5. Run the application (F5 or Ctrl+F5)

## 👥 User Roles & Access

### Customer/Buyer
- Browse agricultural products
- Add products to shopping cart
- Place and track orders
- View order history
- Manage profile

### Seller
- Add and manage products
- Set pricing and inventory
- View sales statistics
- Manage incoming orders
- Track payments

### Agent
- Facilitate buyer-seller transactions
- Earn commissions on sales
- Manage delivery coordination
- View earnings and withdraw funds
- Handle order logistics

### Administrator
- Approve new user registrations
- Manage all users and roles
- Oversee platform operations
- Handle dispute resolution
- Monitor payment distributions
- Generate platform reports

## 🔐 Authentication System

The application implements a secure role-based authentication system:

1. **Registration**: Users register with role selection (Customer, Seller, Agent)
2. **Approval**: Admin approval required for new accounts
3. **Login**: Secure login with email and password
4. **Session Management**: Role-based access control throughout the application
5. **Password Reset**: Email-based password recovery system

## 💳 Payment & Commission System

### Payment Methods
- Cash on Delivery (COD)
- Online Payment (integrated payment gateway)

### Commission Structure
- **Platform Fee**: 5% of each transaction
- **Agent Commission**: Configurable percentage per agent
- **Seller Revenue**: Remaining amount after deductions
- **Automatic Distribution**: Payments automatically distributed upon order completion

## 📱 User Interface

The application features a modern, intuitive Windows Forms interface with:
- Responsive design elements
- Custom user controls for consistent UI
- Dynamic content loading
- Real-time notifications
- Search and filter capabilities
- Shopping cart with live updates

## 🚚 Order Management

### Order Lifecycle
1. **Product Selection**: Browse and add to cart
2. **Checkout**: Review order and select payment method
3. **Order Confirmation**: Order placed and assigned to agent
4. **Processing**: Seller prepares the order
5. **Collection**: Agent collects from seller
6. **Delivery**: Agent delivers to buyer
7. **Completion**: Order marked as delivered, payments distributed

### Order Tracking
- Real-time status updates
- Delivery notifications
- Order history with detailed information
- Cancel order functionality (before processing)

## 🔧 Configuration

### Database Configuration
Update the connection string in `db.cs`:
```csharp
string constring = "Data Source = YOUR_SERVER; Initial Catalog = Farmlink; Integrated Security = True;";
```

### Application Settings
- Default user profile pictures path
- Image storage locations
- Email configuration for notifications
- Commission percentages

## 🐛 Troubleshooting

### Common Issues

1. **Database Connection Error**
   - Verify SQL Server is running
   - Check connection string
   - Ensure database exists

2. **Login Issues**
   - Check user approval status
   - Verify credentials
   - Ensure user role is properly set

3. **Image Loading Problems**
   - Verify image file paths
   - Check file permissions
   - Ensure images folder exists

4. **Cart/Order Issues**
   - Clear browser cache if using CefSharp components
   - Restart application
   - Check database connectivity

## 📈 Future Enhancements

- Mobile application development
- Advanced analytics and reporting
- Integration with external payment gateways
- GPS tracking for deliveries
- Multi-language support
- Push notification system
- Advanced search with filters
- Inventory management automation

## 👨‍💻 Development Team

This project was developed as part of an Object-Oriented Programming course at American International University-Bangladesh (AIUB).

## 📄 License

This project is developed for educational purposes as part of a university coursework.

## 🤝 Contributing

This is an academic project. For educational purposes, please:
1. Fork the repository
2. Create a feature branch
3. Make your changes
4. Submit a pull request with detailed description

## 📞 Support

For technical support or questions about the project:
- Check the troubleshooting section
- Review the code documentation
- Contact the development team

---

**Note**: This application is designed for educational purposes and may require additional security and performance optimizations for production use.