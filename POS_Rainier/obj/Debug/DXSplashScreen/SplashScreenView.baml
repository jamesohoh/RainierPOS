   M S B A M L   `   `   `  ����  POS_Rainier"    POS_Rainier.SplashScreenView   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      a ]DevExpress.Xpf.Core.v14.2, Version=14.2.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a;dx2http://schemas.devexpress.com/winfx/2008/xaml/core  5      .��5      � -   5          �Name$  
LayoutRoot��5      .+�5   
   � -   5        $  Splash��5      $	��450��6   $��Center=�6+   $	��Top=�6H   $��0q�6`   .+�5      � -   5        $
  Back��5      .+�5      �� 
���   � �� CornerRadius$ 3��6,    J� Opacity$
 0.15Q�6=   �� 5      $ 2��6   $��1q�6*   
�������65   5      � 5      -   5        $  Content_Area��5      $��12q�6)    � RowDefinitions 5      �� 5      $
��Auto �6$   �� 5      $
��Auto �6$   �� 5      $��* �6$   �� 5      $
��Auto �6$   .+�5      �� -   5         ��Name$ Image��5      $��	Image.png��6'   $
��None=�6:   �� 5      -   5         ��Name$
 Info��5      $
��Wrap=�6*   $��1��6U   $��
12,12,12,0q�6b   ���	#FF2D2D2D��6>   �� *State+6v   � 5      -   5         �Name$ progressBar��5      $��12��5      $��2��5      $��12q�5       � IsIndeterminate 5      �� *IsIndeterminate+ � Value 5      �� *
Progress+	 � Maximum	 5       �� *MaxProgress+]� 5!      -   5        
 ]�Name$
 Footer��5!      $��3��6,   $��
12,20,12,4q�69   .+�5"      �� -	   5        $ Footer_Text��5"       $
��Wrap=�65   $,��&Copyright © 2015 RainierSoftware Inc.��6I   $	 0.5Q�6v   ���	#FF2D2D2D$
��Left=�6�   $��Center=�6�   �� 5#      -
   5        $ Logotype��5#      $��Right=�6.   $��Logo.png��6E   $
��None=�6W   $��Right=�6f   5$      5%      5&      5'      5(      