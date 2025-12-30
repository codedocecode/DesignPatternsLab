# 01-Strategy Pattern – Playground

## 🎯 Goal

Learn the **Strategy pattern** by solving a real design problem using
polymorphism instead of conditionals.

This is a hands-on exercise.
You are expected to **write the code**, not just read it.

---

## 🧠 Problem

In an order management system, the **final price of an order depends on the type of customer**.

Initial rules:

| Customer Type | Pricing Rule |
|--------------|--------------|
| Standard     | Pays 100% of the base price |
| Premium      | Gets a 10% discount |
| Employee     | Gets a 30% discount |

These rules **will change over time**, and **new customer types will be added**.

---

## ❌ Naive Solution (DO NOT IMPLEMENT)

```csharp
decimal CalculatePrice(Order order)
{
    if (order.CustomerType == CustomerType.Standard)
        return order.BasePrice;

    if (order.CustomerType == CustomerType.Premium)
        return order.BasePrice * 0.9m;

    if (order.CustomerType == CustomerType.Employee)
        return order.BasePrice * 0.7m;

    throw new Exception("Unknown customer type");
}
```

# ❌ Problems with This Approach

- Violates the **Open/Closed Principle**
- Requires modifying existing code for every new rule
- Logic becomes harder to test and maintain
- Business rules are tightly coupled

---

# ✅ Desired Outcome

Design a solution where:

- Pricing algorithms are **interchangeable**
- The **order does not know** the pricing rules
- Adding a new pricing rule means **adding a new class**
- **No conditionals** are used to select behavior

---

# 📐 Constraints

## ✔ Use

- Interfaces  
- Polymorphism  
- Composition  

## ❌ Do NOT use

- `if` / `switch` to select behavior  
- Dependency Injection frameworks  
- Enums as decision makers  

---

# 🧩 Hints (Not the Solution)

- Think about an abstraction that represents  
  **“a way to calculate a price”**
- Each pricing rule should live in **its own class**
- The order should **delegate** the calculation

---

# ✍️ Tasks

1. Define an interface for the **pricing strategy**
2. Implement pricing strategies:
   - `StandardPricingStrategy`
   - `PremiumPricingStrategy`
   - `EmployeePricingStrategy`
3. Create an `Order` (or similar class) that:
   - Has a **base price**
   - Receives a **pricing strategy**
   - Calculates the final price by **delegation**
4. *(Optional)* Add a small console example or test

---

# 🧠 What You Should Learn

- When **Strategy** is the right tool
- How to eliminate conditionals using **polymorphism**
- Why **composition** is preferred over inheritance here

---

# 🚦 When You Are Done

You should be able to add a new pricing rule  
**without changing existing code**.


