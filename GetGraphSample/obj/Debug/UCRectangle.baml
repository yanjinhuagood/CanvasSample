   M S B A M L   `   `   `  ����I  EGetGraphSample, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:GetGraphSampleGetGraphSample  5           GetGraphSample.UCRectangle   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:GetGraphSample     5      -   5          � 	Resources  5      *   $GetGraphSample.ColorToBrushConverter   colorToBrushConverter �� DataType#   GetGraphSample.RectangleModel � Cursor �� 	Converter
 � Tag � ToolTip��%L  &	        (��      5      *, +)7     5   
   5      �� 5   
   "  5      .R�5      � $��0,2,2,2q�5      .+�5      �� $
 Hand��5      ��5      �� *Width+��5      �� *Height+��5      �� *Color+8    5      �� *UUID+ 5      �� *	ToolTip+5      5      5        � DataContext 5!      )   #GetGraphSample.UCRectangleViewModel  5"   
   .��5$      � .+�5%   
   �� -   5         ��Name$ listBox��5&       �� SelectionMode$ Extended=�5(      $��0q�6&   ��5'      �� *
Rectangles+��5*      �� 5+      .R�5,      �� 5-      ��5/      �� 50      	 �� 
TargetType"	 ��51      .�53      �� 
 �� Property
 �@��Left �� Value 55      �� *X+�� 57      
 �@��Top 59      �� *Y+5;      5=      �� 5?   
   -   5         ��Name$ dragSelectionCanvas��5@      $y�	Collapsed=�5A      .+�5C      �� -   5         ��Name$ dragSelectionBorder��5D      
����  �$��1q�5F      
����ح� �� CornerRadius$ 1��5H       J� Opacity$	 0.5Q�5I      5K      5L      5M      