# iPark: Intelligent Parking

## Project Description

iPark: Intelligent Parking is a machine learning project that utilizes Unity ML-Agents, Reinforcement Learning (RL), and the Unity game engine to create an intelligent system capable of parking a car in various dynamic scenarios. This project aims to demonstrate the application of AI in real-world scenarios and provide insights into the performance of different machine learning models in a simulated environment.

## Installation

To install iPark: Intelligent Parking, follow these steps:

1. Go to the [releases section](https://github.com/KushagraYashu/iPark/releases/tag/setup) of the GitHub repository.
2. Download the `iParkSetup` file.
3. After downloading, Launch the `iParkSetup` file.
4. Choose the setup language.
5. Select the user account for installation.
6. Opt to create a desktop icon (optional).
7. Wait for the setup to complete.

To launch the application:
- Either tick the launch button before closing the setup, or
- Use the desktop icon if created, or
- Navigate to `C:\Program Files (x86)\iPark Intelligent Parking` and launch the `iPark.exe` file.

## Usage Instructions

1. **Main Menu**:
   - **Start**: Launches the main scene.
   - **Developer Stats**: Opens a PDF containing training efficiencies of all models as reported by developers.
   - **Exit**: Quits the application.

2. **Main Scene**:
   - **Model Selection**: Choose from 7 different models to perform the parking task.
   - **Navigation**: Use the `WASD` keys and mouse movement to look around the 16 dynamic parking scenarios.
     - Left Mouse Button: Zoom in.
     - Right Mouse Button: Zoom out.
   - **Efficiency Calculation**: 
     - The bottom left of the screen shows controls.
     - The top left section shows the efficiency UI.
     - Press `E` to calculate and display the current efficiency of all scenarios combined. This information is also saved in a text file for later viewing.
   - **Reset and Exit**:
     - **Reset**: Reloads the current scene to restart the evaluation process.
     - **Exit**: Returns to the Main Menu.

3. **Efficiency Log**:
   - Navigate to `C:\Users\[YOUR USERNAME]\AppData\LocalLow\Kushagra\iPark_ Intelligent Parking`.
   - If the "AppData" folder is not visible, enable hidden items in your file explorer (View->Hidden Items).
   - Open the `Efficiency.txt` file to view efficiency data, including timestamps and model descriptions.
   - Example of Efficiency Log <br/>
     `25-05-2024 22:47:17 (Testing Model "iPark [02] 28-03-2024-10000026 (Unity.Barracuda.NNModel)")`  
     `Efficiency 91.66667%`  
     `Total Park 11`  
     `Total Collision 1`  
     `Total Cases 12`  

## Contributing

For contributions, please contact the project lead via the email provided below. Contributions are welcome from all interested individuals, especially those with expertise in Unity, machine learning, and AI.

## Contact Information

This README is provided by Kushagra (AKTU Roll No: 2000271530029). This project was developed by Group 103, BTech CSE AIML.

**Project Members**:
- Kushagra (2000271530029)
- Abhinav Sajjan (2000271530006)
- Himanshu Mishra (2000271530024)
- Shreyashi Jaiswal (2000271530056)

**Email**: kushagra102004@gmail.com
