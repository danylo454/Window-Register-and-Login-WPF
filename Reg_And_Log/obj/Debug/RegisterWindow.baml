   M S B A M L   `   `   `  ����F  BReg_And_Log, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Reg_And_LogReg_And_Log  5   	        Reg_And_Log.RegisterWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:Reg_And_Log     5   	   ���#000  � WindowStartupLocation$  CenterScreen=�5	   	    � Title$ RegisterWindow��5
   	   $	��550��6    $	��400��6-   .��5      � -   5         �Name$	 reg��5      ���#000$��20,20,20,20q�6*   .+�5   
   �� -   5         ��Name$ registerStackPanel��5      .+�5      �� 
�������$��Register��6'   $��Center=�6:   $��30(�6W   $
��Bold"�6e   � 5      $��	0,20,0,20q�6   .+�5      �� 
�������$
��Name��6+   $
��Left=�6:   $��20(�6U   $
��Bold"�6c   �� 5      -   5         ��Name$ nameTextBox��5   @    � ToolTip$ 
Enter Name��6U   $��Right=�6j   $	��250��6�   $
��Bold"�6�   5      � 5      $��	0,20,0,20q�6   .+�5      �� 
�������$��Surname��6+   $
��Left=�6=   $��20(�6X   $
��Bold"�6f   �� 5      -   5        $ surnameTextBox��5   @   $ Enter Surname��6X   $��Right=�6p   $	��250��6�   $
��Bold"�6�   5      � 5      $��	0,20,0,20q�6   .+�5      �� 
�������$��Login��6+   $
��Left=�6;   $��20(�6V   $
��Bold"�6d   �� 5      -   5        $ loginTextBox��5   V   $ Enter Login��6@   $��Right=�6l   $	��250��6�   $
��Bold"�6�   5      � 5      $��	0,20,0,20q�6   .+�5      �� 
�������$��Password��6+   $
��Left=�6>   $��20(�6Y   $
��Bold"�6g   �� 5      -   5        $ passwdTextBox��5   Y   $ Enter Password��6@   $��Right=�6p   $	��250��6�   $
��Bold"�6�   5      � 5      $��	0,20,0,20q�6   .+�5      �� 
�������$��Password��6+   $
��Left=�6>   $��20(�6Y   $
��Bold"�6g   �� 5       -   5        $ repitPasTextBox��5    Y   $ Enter Password��6@   $��Right=�6r   $	��250��6�   $
��Bold"�6�   5!      � 5"      .+�5#      �� -   5         ��Name$ 	canselBtm��5#   1   $
��Left=�6D   $��20,0,0,-0.5q�6_   $��Cansel��6t   $��25(�6�   $
��Bold"�6�   $��38��6�   $	��Top=�6�   �� 5$      -	   5        $ registerBtm��5$   3   $��Register��6H   $��0,0,20,-0.5q�6[   $��Right=�6p   $��25(�6�   $
��Bold"�6�   $��38��6�   $	��Top=�6�   5%      5&      5'      5(      