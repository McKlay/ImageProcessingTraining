# 🖼️ ImageProcessingTraining

A C# WinForms project for learning and experimenting with image processing techniques. Built for academic training with real-time image manipulation and enhancement features.

---

## 🔧 Features

- Load and save images
- Real-time image preview using `PictureBox`
- Grayscale conversion, mirroring, and inversion
- Brightness adjustment via slider
- Histogram plotting and equalization
- Subtraction-based green screen effect
- 🔬 **Advanced enhancement filters via convolution matrix:**
  - Sharpen
  - Edge Detection
  - Box Blur
  - Gaussian Blur
  - Emboss
  - Edge Enhancement
  - Mean Blur
  - Sobel Vertical
  - Laplacian

---

## 🧠 Purpose

This project was created for academic training and hands-on practice in image processing using C#, WinForms, and .NET 8. It demonstrates the use of bitmap manipulation, convolution filters, histogram equalization, and pixel-level optimization using `LockBits`.

---

## 📁 Project Structure

- `ImageProcessingTraining/` – Source code (Forms, image processing logic, matrix presets)
- `ConvMatrix.cs` – Convolution matrix factory class
- `BasicDIP.cs` – Core processing class with grayscale, histogram, convolution, etc.
- `savedImage/` – Folder for saved outputs and demo screenshots

---

## 🚀 How to Run

1. Clone this repository:
   ```bash
   git clone https://github.com/your-username/ImageProcessingTraining.git
