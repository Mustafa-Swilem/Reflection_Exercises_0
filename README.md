# C# Reflection Exercises 0

A simple C# console application that demonstrates **Reflection** by creating objects at runtime from a class name typed by the user.

## Overview
1. The program asks for an enemy type: `Goon`, `Warrior`, or `Mage`.
2. It builds the full class name and creates an instance dynamically.
3. It prints the object's stats and runs the action that matches its type.
4. If the class does not exist, it shows an error and asks again.

## Concepts Used
- **Reflection**: creating objects from a string instead of using `new`.
- **Activator.CreateInstance(assemblyName, typeName)**: creates an instance by assembly and type name.
- **Unwrap()**: converts the returned `ObjectHandle` into the actual object.
- **Assembly metadata**: `typeof(Program).Assembly.GetName().Name` gets the current assembly name.
- **Pattern matching**: `switch (obj)` with `case Goon goon:` to detect the real type.
- **Exception handling**: `try/catch` for invalid class names.
- **ToString override**: prints each enemy's stats.

## Code Structure
| Element | Purpose |
|---------|---------|
| `Program` | Reads user input, creates the object with Reflection, and runs the matching action |
| `Goon` | Basic enemy (Speed 20, HitPower 13, Strength 7) |
| `Warrior` | Strong melee enemy (Speed 15, HitPower 25, Strength 30) |
| `Mage` | Spell caster (Speed 18, HitPower 35, Strength 10) |

## How to Run
```bash
dotnet run
```

## Example
```
Enter enemy type (Goon, Warrior, Mage): Mage
Created Successfully: ( Mage -> Speed: 18, HitPower: 35, Strength: 10 )
Action: Mage is casting a fire spell!
```

## Extending
Add a new enemy class (for example `Archer`) and add a `case` for it in the `switch`. The creation code does not change, because the type is resolved at runtime.
