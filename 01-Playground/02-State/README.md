# State Pattern – Playground

## 🎯 Goal

Learn the **State pattern** by modeling the different states of an order
(Created, Paid, Shipped, Completed) without using conditional statements.

This is a hands-on exercise.
You are expected to **write the code**, not just read it.

---

## 🧠 Problem

In an order management system, an order can be in one of several states:

| State      | Allowed Transitions           |
|------------|-------------------------------|
| Created    | Pay → Paid                   |
| Paid       | Ship → Shipped               |
| Shipped    | Complete → Completed         |
| Completed  | No further transitions       |

Rules:

- The order should **change its behavior depending on its current state**
- Avoid using `if`/`switch` for state management

---

## ❌ Naive Solution (DO NOT IMPLEMENT)

```csharp
void ChangeState(Order order)
{
if(order.State == OrderState.Created)
{
    order.Pay();
}
else if(order.State == OrderState.Paid)
{
    order.Ship();
}
else if(order.State == OrderState.Shipped)
{
    order.Complete();
}
}
```

### Problems:

- Violates Open/Closed Principle
- Hard to extend with new states
- Logic is tightly coupled
- Difficult to test individual state behavior

---

## ✅ Desired Outcome

- Each state encapsulates its own behavior
- The order delegates state-specific behavior to the current state
- Adding a new state means adding a new class
- No conditionals are used to check the state

---

## 📐 Constraints

✔ Use:

- Interfaces or abstract classes
- Polymorphism
- Composition

❌ Do NOT use:

- `if` or `switch` to handle states
- Enums as decision makers

---

## 🧩 Hints

- Define an `IOrderState` interface with methods for the possible actions (e.g., `Pay`, `Ship`, `Complete`)
- Each concrete state implements the interface
- The `Order` class delegates behavior to the current state instance
- Think about what should happen if an action is invoked in the wrong state
- Optional: use a simple console example or test to move an order through its lifecycle

---

## ✍️ Tasks

1. Define IOrderState interface
2. Implement concrete states (Created, Paid, Shipped, Completed)
3. Create Order class that delegates behavior to the current state
4. Optional: Console example to move an order through its lifecycle

---

## 🧠 What You Should Learn

- When to use the State pattern
- How to remove conditional logic for state-specific behavior
- How to extend behavior by adding new states without modifying existing code

---

## 🚦 When You Are Done

You should be able to add a new order state and corresponding behavior **without touching existing code**.

---