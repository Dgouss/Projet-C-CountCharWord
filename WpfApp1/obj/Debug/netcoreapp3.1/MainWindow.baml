   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	       WpfApp1.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � WindowStartupLocation$ CenterScreen=�65   .��5	      � .+�5
   
   �� $��	Source : ��6   $��68,80,357,0q�6$   $	��Top=�69   �� 5   
   -   5         ��Name$ Source��5      $�� ��6"   $
��Left=�6*   $��
148,88,0,0q�6E    �� TextWrapping$
 Wrap=�6Y   $	��Top=�6m   $	��313��6�   6�   �� 5   
   $"��Sauvegarder les résultats ?��6   $
��Left=�66   $��
68,122,0,0q�6Q   $	��Top=�6e   $	��150��6}   �� 5   
   -   5         ��Name$	 Yes��5      $	��Oui��6    $
��Left=�6.   $��245,127,0,0q�6I   $	��Top=�6^   6v   �� 5   
   -   5        $ No��5      $	��Non��6   $
��Left=�6-   $��344,127,0,0q�6H   $	��Top=�6]   6u   � 5   
   -   5        $��ProgressBar��5   .   $	��400��6   $��40��6"   $��68,217,332,177q�6A   �� 5   
   -   5        $��pourcent��5      $��427,188,0,177q�6    $
��Left=�67   $	��150��6R   �� 5   
   -   5        $��ProgressTextBox��5   1   $��Center=�6   61   �� 5   
   -   5        $��Lancer le programme��5      $
��Left=�6/   $��189,358,0,0q�6J   $	��Top=�6_   $	��150��6w   6�   �� 5   
   -   5        $ 
Save_entry��5      $
��Left=�6&   $��230,165,0,0q�6A   $
 Wrap=�6V   $	��Top=�6j   $	��231��6�   6�   �� 5   
   -	   5        $
��Save��5      $��Nom de la sauvegarde
��6   $
��Left=�6E   $��
68,162,0,0q�6`   $	��Top=�6t   $	��150��6�   �� 5   
   
���   �$��10q�6,   $��498,68,10,95q�6B   .��5      �� -
   5        $��resultWatch��5   8   $
��Wrap=�6   $	��256��6,   68   5      5      5      