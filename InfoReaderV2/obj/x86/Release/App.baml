   M S B A M L   `   `   `  ����   Kalkulator Zapremine    InfoReaderV2.App   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml       �� 	Resources   �� 
TargetType �� Property �� Value �� 
TargetType � 	Resources   Key g� 	BeginTime �� 
TargetName �� TargetProperty	 p� KeyTime
 p� Value �� 	KeySpline R� KeyTime  System.Windows.Visibility   Visible R� Value O� KeyTime O� Value �Name ��Name �� RadiusX �� RadiusY �� EndPoint �� 
StartPoint �� RelativeTransform �� CenterX �� CenterY �� CenterX �� CenterY �� CenterX �� CenterY � Color � Offset  ��Name! J� RenderTransformOrigin" T� X# �� Triggers$ P� Property% P� Value& N� ExitActions' ��Name  overBack( �� BeginStoryboardName) N� EnterActions  over  overline 	 press* �� 
TargetName+ � MappingMode, J� SnapsToDevicePixels- ��Name. �� CornerRadius/ �� Padding0 ��Name1 �� RelativeSource2 �� AncestorType3 ]� 
Conditions4 �� Property5 �� Value6 �� Triggers��%/  '��       7  7  7  7  '�� �    �� " ��.���  � �� �� " �� ���� over  .��r� $ 00:00:00X�$ title��$ (FrameworkElement.Margin)�.	��� $	 00:00:00��$
 0q��� $ 0.5,0,0.5,1��$	 00:00:00.5000000��$
 	0,-60,0,0q��� $	 00:00:00.7000000��$
 	0,-55,0,0q�r� $ 00:00:00X�$ 	titleOver��$ (FrameworkElement.Margin)�.	��� $	 00:00:00��$
 	0,0,0,-55q��� $	 00:00:00.5000000��$
 0,0,0,5q�$ 0.5,0,0.5,1���� $	 00:00:00.7000000��$
 0q��� overBack  .��r� $ 00:00:00X�$ title��$ (FrameworkElement.Margin)�.	��� $	 00:00:00��$
 	0,-55,0,0q��� $ 0.5,0,0.5,1��$	 00:00:00.5000000��$
 0,5,0,0q��� $	 00:00:00.7000000��$
 0q�r� $ 00:00:00X�$ 	titleOver��$ (FrameworkElement.Margin)�.	��� $	 00:00:00��$
 0q��� $ 0.5,0,0.5,1��$	 00:00:00.5000000��$
 	0,0,0,-60q��� $	 00:00:00.7000000��$
 	0,0,0,-55q��� 	press  .��T� $ 00:00:00X�$ bgPress��$ (UIElement.Visibility)�..�i� $ 00:00:00��# Z i� $ 00:00:00.7000000��# Z U� $ 00:00:00X�$ bgPress��$ (UIElement.Opacity)�.\��� $ 00:00:00��$ 0Q��� $ 00:00:00.4000000��$ 1Q��� $ 00:00:00.7000000��$ 0Q��� overline  .��U� $ 00:00:00X�$ bg��$b \(Shape.Stroke).(Brush.RelativeTransform).(TransformGroup.Children)[3].(TranslateTransform.X)�.\��� $ 00:00:00��$ -1.061Q��� $ 00:00:01.1000000��$ 1.024Q��� $ 00:00:02.5000000��$ 1.024Q�U� $ 00:00:00X�$ bg��$b \(Shape.Stroke).(Brush.RelativeTransform).(TransformGroup.Children)[3].(TranslateTransform.Y)�.\��� $ 00:00:00��$ 0Q��� $ 00:00:01.1000000��$ 0.001Q��� $ 00:00:02.5000000��$ 0.001Q�.R�� $
 grid��}�. .+��� $ bg��$ 2��$ 2��#��z������ $ 1.04,0.5&�$ 	-0.01,0.5&� V� .~��� $	 0.5Q�$	 0.5Q��� $	 0.5Q�$	 0.5Q��� $	 0.5Q�$	 0.5Q�T� .��� $ 	#FF595959��$ 0Q�� $ White��$	 0.7Q�� $ 	#FF303030��$ 1Q��� $ bgBling��$ 2��$ 2��$��2,2,2,20q���Z� ���� $ 0.5,1&�$ 0.5,0&�.��� $ 	#00FFFFFF��$ 1Q�� $ 	#B2FFFFFF��$ 0Q��� $  title��$��Center=�$��Center=�$
��Wrap=�#��z���� $ bgPress��$ 8��$ 8��$��2��$y�Hidden=�$! 0.5,0.5&���Z� z�V� .~��� �� �� T� ���� $ 0.967,1.042&�$ 0.076,-0.042&� V� .~��� $	 0.5Q�$	 0.5Q��� $	 0.5Q�$	 0.5Q��� $	 0.5Q�$	 0.5Q�T� $" -0.458Q�.��� $ 1Q�$ White��� $ White���� $  	titleOver��$��Center=�$��Center=�$
��Wrap=�#��z��$��	0,0,0,-60q�$
��Bold"�$��13.333(�# P� $ �@J�IsMouseOver% . & �� $' overBack_BeginStoryboard��8��  �� $( overline_BeginStoryboard��) �� 8�� �� $' overline_BeginStoryboard��8�� P� $ � ��% . ) �� $' press_BeginStoryboard��8�� . ��� $* bgPress�� � �� �� $ 0.967,1.042&�$ 0.076,-0.042&� V� .~��� $	 0.5Q�$	 0.5Q��� $	 0.5Q�$	 0.5Q��� $	 0.5Q�$	 0.5Q�T� $" -0.458Q�.��� $ 0Q�� $ 1Q�P� $ � {�% .  ��  � �� �� $ 0.5,1&�$ 0.5,0&�$+ RelativeToBoundingBox=�.��� $ 	#FFF0F0F0��$ 0.149Q�� $ 	#FF9F9F9F��$ 1Q�� $ 	#FFA8A8A8��$ 0Q�� $ White��$ 0.335Q��� " ��.���  � ��
 �������  � ��$ 6,1,6,1q���  � ��$ Stretch=���  � ��$ Stretch=���  � �� �� " ��.R�� , . .+��� $- Bd��$��1,1,1,0q�$. 0,10,0,0��$��0,0,-5,0q�$
/ 10,2q����� $ 
0.92,0.518&�$ 0.045,0.518&�.��� $ 	#FF747474��$ 0Q�� $ White��$ 0.533Q�� $ 	#FFB3B3B3��$ 1Q����� $	 0,1&�$	 0,0&�.��� $ 	#FF939393��$ 0Q�� $ 	#FF5E5E5E��$ 0.276Q�� $ 	#FF2A2A2A��$
 0.28Q�� $ 	#FF2A2A2A��$ 1Q�._��� $0 Content��#, z, $��Header����. ���� *HorizontalContentAlignment+1 �� "2 ������ *VerticalContentAlignment+1 �� "2 ��# P� $ �@J�IsMouseOver% . . ��� $* Bd�� � ��
 ������� $* Bd�� � �� �� $ 0.5,1&�$ 0.5,0&�.��� $ Black��$ 0Q�� $ 	#FF848484��$ 0.111Q�� $ 	#FFC5C5C5��$ 1Q�P� $ �@��
IsSelected% . . ���  �@K�ZIndex$ 1���� $* Bd�� � �� �� $ 0.5,1&�$ 0.5,0&�.��� $ 	#FFCECECE��$ 0Q�� $ White��$ 1Q�P� $ �@��TabStripPlacement$% Bottom=�. ��� $* Bd�� � ��$ 1,0,1,1q�P� $ �@��TabStripPlacement$
% Left=�. ��� $* Bd�� � ��$ 1,1,0,1q�P� $ �@��TabStripPlacement$% Right=�. ��� $* Bd�� � ��$ 0,1,1,1q�]� 3 �� 4 �@��
IsSelected5 . �� 4 �@��TabStripPlacement$	5 Top=�./���  � ��$ -2,-2,-2,-1q��� $* Content�� � ��$ 0,0,0,1q�]� 3 �� 4 �@��
IsSelected5 . �� 4 �@��TabStripPlacement$5 Bottom=�./���  � ��$ -2,-1,-2,-2q��� $* Content�� � ��$ 0,1,0,0q�]� 3 �� 4 �@��
IsSelected5 . �� 4 �@��TabStripPlacement$
5 Left=�./���  � ��$ -2,-2,-1,-2q��� $* Content�� � ��$ 0,0,1,0q�]� 3 �� 4 �@��
IsSelected5 . �� 4 �@��TabStripPlacement$5 Right=�./���  � ��$ -1,-2,-2,-2q��� $* Content�� � ��$ 1,0,0,0q�P� $ � {�% .  . ��� # � �� � ��6 P� $ �@��
IsSelected% .  . ���  � ��
 �����P� $ �@��
IsSelected% . . ���  � ��
 �   �