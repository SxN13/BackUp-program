   M S B A M L   `   `   `  ���� I  EBackUp program, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:BackUp_programBackUp_program      BackUp_program.MainWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     .localclr-namespace:BackUp_program       � Title$<  6Резервное копирование данных��$��181.4��$	��398��
�������
���   � � 
ResizeMode$ NoResize=�����  �� EndPoint$ 0.5,1&� �� 
StartPoint$ 0.5,0&�.���  � Color$ Black�� � Offset$ 0Q�� $ White��$ 1Q�.��� $
��Left=�$	��393��$	��151��$	��Top=�$��0,0,-1,0q� � ColumnDefinitions �� $
��370* ��� $	��23* ����� $ 0.5,1&� � MappingMode$ RelativeToBoundingBox=�$ 0.5,0&�.��� $ 	#FF3074B4��$ 0.003Q�� $ 	#FF8CDCFF��$ 1Q� � RowDefinitions �� $
��110* ��� $	��51* �.+��� -   	 ��Name$	 pathNameBox��$
��Left=�$��30��$��	10,10,0,0q�
 �� TextWrapping$

 Wrap=�$�� ��$	��Top=�$	��365��$��Center=�$��2�����	#FFFFFDC0�� -    ��Name$ backUp_botton��$��Создать копию��$
��Left=�$��
260,81,0,0q�$	��Top=�$	��115��$��22�����	#FF6AC1FF$��Center=�$��2���� -   $ 
fileChoose��$��Выбрать файл��$
��Left=�$��
135,81,0,0q�$	��Top=�$	��115��$��22�����	#FFC1FFF3$��Center=�
���   ��� -   $ directoryChoose��$#��Выбрать каталог��$
��Left=�$��	10,80,0,0q�$	��Top=�$	��115��$��23�� J� RenderTransformOrigin$ -0.497,0.891&����	#FFA7FFE4���	#FF666666$��Center=��� -    ��Name$ statusLabel��$�� ��$
��Left=�$��
10,6.8,0,0q�$	��Top=�$��26��$	��365��$��1��$��2���� -   $ copiedLabel��$�� ��$
��Left=�$��260,6.8,0,0q�$	��Top=�$��26��$	��115��$��1��$��13(�$��	ExtraBold"�$��Center=�$��Center=����	#FF2DDD00$��2���� -   $	 passBox��$
��Left=�$��30��$��	10,45,0,0q�$

 Wrap=�$��Пароль��$	��Top=�$	��240�����	#FFC0FCFF4  .System.Windows.Automation.AutomationProperties   HelpText$ Пароль��{�.  $��Center=��� -    ��Name$ pass_checkbox��$��Шифровать��$
��Left=�$��
260,45,0,0q�$	��Top=�$	��115��$��30��$��Center=�$��2��