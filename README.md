# 🍕 Build Your Pizza

A desktop pizza ordering application built with **C# Windows Forms**, where users can customize their own pizza step-by-step and see the total price update in real time.

---

## 📖 About

**Build Your Pizza** lets the user go through a simple, visual ordering flow: pick a size, choose a crust, add toppings, and decide whether to eat in or take away — with the order summary and total price updating live as they make each choice.

---

## ✨ Features

- 🏠 **Welcome / Home screen** with a "Get Started" call to action
- 🍕 **Choose Size** — Small ($20), Medium ($30), Large ($40)
- 🥖 **Choose Crust Type** — Thin ($0), Thick (+$10), Stuffed (+$15)
- 🧀 **Toppings** (multi-select, $5 each) — Extra Cheese, Onion, Green Peppers, Mushrooms, Olives, Tomatoes
- 🍽️ **Where to Eat** — Take Away or Eat In
- 🧾 **Live Order Summary** — shows selected size, crust, toppings, and location
- 💰 **Automatic Total Price Calculation**
- 🔄 **Reset Form** button to start a new order
- ✅ **Place Order** button to confirm the order

---

## 🖼️ Screenshots

### Home Page
Welcome screen introducing the app before the user starts building their pizza.

### Order Page
The main ordering screen where the user selects size, crust, toppings, and dining option, with a live summary panel on the right.

---

## 🛠️ Built With

- **C#**
- **Windows Forms (.NET)**
- **Visual Studio**

---

## 🎯 Concepts Practiced

This project was built as part of learning the **C# backend track**, and covers:

- Enums (`enum`) for representing size and crust choices
- `RadioButton` groups (`GroupBox`) for single-choice options
- `CheckBox` for multi-select toppings
- Event-driven programming (`CheckedChanged`, `Click`)
- Dynamic UI updates and price calculation
- Basic form validation

---

## 🚀 How to Run

1. Clone the repository
   ```bash
   git clone https://github.com/NahlaX30/Pizza-Project.git
   ```
2. Open `Pizza Project.sln` in **Visual Studio**
3. Press **F5** (or **Start**) to run the application

---

## 📌 Status

🚧 Learning project — actively being improved as new C# concepts are practiced.
