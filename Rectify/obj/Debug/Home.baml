   M S B A M L   `   `   `  ����B  >Rectify, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:RectifyRectify  5   	       Rectify.Home   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Rectify     5   	   -   5          � Title$
  Home��5   	      windowStyle#��[  6.    � Icon$ Media/Dvtlogo.png��6U    � 	Resources 5	      ��%    5      .��5      � .+�5   
   � .+�5      � $��10,10,-10,-10q�6    � RowDefinitions 5      �� 5      �� 5      �� 5      �� 5      �� 5       � ColumnDefinitions 5      �� 5      $	��100 �6'   �� 5      $
��173* �6'   �� 5      $
��173* �6'   �� 5      $
��173* �6'   �� 5      $
��173* �6'   �� 5      $��5 �6'   .+�5      �� $��Learnership Tasks��6   $��1��65   
�������$��2��6U   $��Bottom=�6i   $
��Bold"�6�   $��22(�6�   $��Right=�6�   $	��208��6�   $��0,0,26,9q�6�   $��1��6�   �� 5      $��Administration��6   $��1��62   $��3��6?   
�������$��3��6b   $��Bottom=�6v   $
��Bold"�6�   $��22(�6�   $��Right=�6�   $	��294��6�   $��0,0,-55.333,9q�6�   �� 5       -   5        $��2��5       $��1��6&     myHomeButton#��[ 68   .��5!      �� Daily�� 6&   
Register6;   5"      �� 5#      #��[ 6   $��2��6A   $��2��6N   .��5$      �� Weekly�� 6'   	Logbook6;   5%      �� 5&      #��[ 6   $��3��6@   $��1��6M   .��5'      �� 	Monthly�� 6(   
Evaluation6?   5(      �� 5)      -   5         ��Name$ 	btnManage��5)      #��[ 6,   $��3��6j   $��0,0,0,1q�6z   $��2��6�   $��2��6�   .��5*      �� User�� 6%   
Management6<   5+      �� 5-      -   5         ��Name$ pageLogo��5-   !   $��0��63   $��2��6@     LogoTemplate#��[ 6P   $��Bottom=�6�   $��0,0,0,45q�6�   $��59��6�    J� RenderTransformOrigin$ 0.388,0.388&�6�   $��2��6�   $
��Left=�6�   $	��189��6  �� 5/      -   5         ��Name$ 	LoginName��5/      
�������$
��Bold"�6W   $��Center=�6j   $��Right=�6�   $��36��6�   $	��212��6�   $��3��6�   $��3��6�   $��0,23,-16,55q�6�   $ 0.714,0.486&�6�   ��6/   �� 6�   �� 50      -   5        $ btnBack��50      $
��Left=�6+   $��	10,10,0,0q�6F   $	��Top=�6Y   .��51      �� .+�52      �� $��Media/back.jpg��6    $��38��68   $
��Left=�6D   $��41��6_   53      54      �� 56      $��
0,23,18,52q�6   $��4��62   $ -0.469,0.485&�6B   $��Right=�6g   $��21��6�   .+�57      �� $
��Wrap=�6    
�������$��38��6G   $��	-17,0,0,0q�6S   $ 0.093,1.658&�6f   $
��Left=�6�   $��38��6�   �� 6�   -   5        $��18(�57   �   $	�▼��6�   
�������6�   6�   � 58      -   5        	 �Name$	 popLink��58      
 � 	StaysOpen
 .  $��Mouse=�6?   $	��200��6Q   $��Scroll=�6`    � AllowsTransparency . .��59      �� 
�������$��2q�65   
�������._�5:      �� $��10q�6(   $
��Wrap=�64   �� 6I   -	   5        $
��Bold"�5:   S   $��16(�6e   .�6�   �� $�About��6�   6�   �� 5;   !   �� 6-   -
   5        $
��Bold"�5;   8   $��16(�6J   .�6k   �� $�Logout��6o   6�   5<      5=      5>      5?      5@      5A      5B      5C      