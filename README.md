# Simple To-Do List Tool (C#)

A minimalist, console-based task management tool developed in C#. This project serves as a practical application of core programming concepts within the .NET environment.

## Features
- Add Tasks: Quickly capture and store new to-do items.
- View Tasks: Display all current entries in an organized, numbered list.
- Delete Tasks: Remove specific items from the list using their index number.
- Input Validation: Robust handling of user input to prevent crashes (e.g., handling non-numeric characters).

## Technical Implementation
Through the development of this tool, the following C# concepts were implemented:
- Lists (List<string>): Used for dynamic data storage to allow the task list to grow and shrink.
- Methods: Structured code into logical, reusable blocks such as Menu, NewTask, and ViewTask.
- Loops: Implemented while(true) for the main program cycle and foreach/for loops for list iteration.
- Switch Statements: Used to control program flow based on user selection.
- Error Handling: Utilized int.TryParse to ensure the application remains stable during unexpected user input.

## Console Preview
```text
----------- MAIN MENU -----------
1. [Add]    New Task
2. [View]   Current Tasks
3. [Delete] Remove a Task
4. [Exit]   Close Program
---------------------------------
Your selection: _
