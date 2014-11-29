﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Zyrenth.OracleHack.Wpf
{
	/// <summary>
	/// Interaction logic for ViewSecretsWindow.xaml
	/// </summary>
	public partial class ViewSecretsWindow : Window
	{
		GameInfo _info;

		public ViewSecretsWindow()
		{
			InitializeComponent();
		}

		public ViewSecretsWindow(GameInfo info) : this()
		{
			_info = info;
			SetSecrets();
		}

		private void SetSecrets()
		{
			uxGameSecret.SetSecret(_info.CreateGameSecret());
			uxRingSecret.SetSecret(_info.CreateRingSecret());
			
			if (_info.Quest == Quest.LinkedGame)
			{
				bool returnSecret = true;
				uxMemSecret01.SetSecret(_info.CreateMemorySecret(Memory.ClockShopKingZora, returnSecret));
				uxMemSecret02.SetSecret(_info.CreateMemorySecret(Memory.GraveyardFairy, returnSecret));
				uxMemSecret03.SetSecret(_info.CreateMemorySecret(Memory.SubrosianTroy, returnSecret));
				uxMemSecret04.SetSecret(_info.CreateMemorySecret(Memory.DiverPlen, returnSecret));
				uxMemSecret05.SetSecret(_info.CreateMemorySecret(Memory.SmithLibrary, returnSecret));
				uxMemSecret06.SetSecret(_info.CreateMemorySecret(Memory.PirateTokay, returnSecret));
				uxMemSecret07.SetSecret(_info.CreateMemorySecret(Memory.TempleMamamu, returnSecret));
				uxMemSecret08.SetSecret(_info.CreateMemorySecret(Memory.DekuTingle, returnSecret));
				uxMemSecret09.SetSecret(_info.CreateMemorySecret(Memory.BiggoronElder, returnSecret));
				uxMemSecret10.SetSecret(_info.CreateMemorySecret(Memory.RuulSymmetry, returnSecret));
			}

			if (_info.Game == Game.Ages)
			{
				lblMem01.Text = "Clock Shop";
				lblMem02.Text = "Graveyard";
				lblMem03.Text = "Subrosian";
				lblMem04.Text = "Diver";
				lblMem05.Text = "Smith";
				lblMem06.Text = "Pirate";
				lblMem07.Text = "Temple";
				lblMem08.Text = "Deku";
				lblMem09.Text = "Biggoron";
				lblMem10.Text = "Ruul";
			}
			else
			{
				lblMem01.Text = "King Zora";
				lblMem02.Text = "Fairy";
				lblMem03.Text = "Troy";
				lblMem04.Text = "Plen";
				lblMem05.Text = "Library";
				lblMem06.Text = "Tokay";
				lblMem07.Text = "Mamamu";
				lblMem08.Text = "Tingle";
				lblMem09.Text = "Elder";
				lblMem10.Text = "Symmetry";
			}
		}
	}
}
