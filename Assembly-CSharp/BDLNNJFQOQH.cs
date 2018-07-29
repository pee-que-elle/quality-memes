using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using PSXAPI.Request;
using PSXAPI.Response;
using PSXAPI.Response.Payload;
using UnityEngine;

// Token: 0x02000209 RID: 521
public class BDLNNJFQOQH : MonoBehaviour
{
	// Token: 0x060044D1 RID: 17617 RVA: 0x0021A1D4 File Offset: 0x002183D4
	public void JDKEKFPEJBO()
	{
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new LobbyAccept
		{
			State = (LobbyActorState)4
		}, true);
	}

	// Token: 0x060044D2 RID: 17618 RVA: 0x0001D198 File Offset: 0x0001B398
	public void QNOGELBJJOL(LobbyRemove KOEEIBDFFGE)
	{
		if (KOEEIBDFFGE.Name.ToLowerInvariant() == CNCJKLNHQBH.MOGQNGEPCEO().CGKGBEICHMH.ToLowerInvariant())
		{
			this.DKHPHKMMLBF();
		}
	}

	// Token: 0x060044D3 RID: 17619 RVA: 0x0001D1C1 File Offset: 0x0001B3C1
	public void LBJGBQIJOPD(LobbyRemove KOEEIBDFFGE)
	{
		if (KOEEIBDFFGE.Name.ToLowerInvariant() == CNCJKLNHQBH.QOQONHOOLNE.CGKGBEICHMH.ToLowerInvariant())
		{
			this.Close();
		}
	}

	// Token: 0x060044D4 RID: 17620 RVA: 0x0021A1FC File Offset: 0x002183FC
	public void JJQLBJCILGK()
	{
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new LobbyAccept
		{
			State = LobbyActorState.Confirm
		}, false);
	}

	// Token: 0x060044D5 RID: 17621 RVA: 0x0021A224 File Offset: 0x00218424
	public void FFPPKCODBLG(Lobby KOEEIBDFFGE)
	{
		if (!this.QPPGQJFBPMH.gameObject.activeSelf)
		{
			this.Open();
		}
		this.FFCCFEKPFMB.Clear();
		this.KMGCDOHKBGD.Clear();
		this.NOJBMFJLFDL.MKIGNOHIDBM(KOEEIBDFFGE.Leader);
		if (!this.NOJBMFJLFDL.OKJQNGQHIHJ)
		{
			this.NOJBMFJLFDL.FOOOENOGFMD(false);
		}
		this.NOJBMFJLFDL.LEOHQPKNFPK = KOEEIBDFFGE.CanChangeSettings;
		this.NOJBMFJLFDL.PMKIMHMMDPD(false);
		this.NOJBMFJLFDL.NBOMFHNBEGJ(KOEEIBDFFGE.AdjustLevels);
		this.NOJBMFJLFDL.HMGIGQJGLMN(KOEEIBDFFGE.ItemAllowed);
		this.NOJBMFJLFDL.KFFMEGGKBFJ(KOEEIBDFFGE.CanInvite);
		this.NOJBMFJLFDL.FGEDLPIDGFC(KOEEIBDFFGE.CanLeaveLobby);
		this.NOJBMFJLFDL.NOIILDLEFQD(KOEEIBDFFGE.CanSwitchTeam);
		for (int i = 1; i < KOEEIBDFFGE.Actors.Length; i++)
		{
			if (KOEEIBDFFGE.Actors[i].Team == ActorTeam.None)
			{
				this.FFCCFEKPFMB.Add(KOEEIBDFFGE.Actors[i]);
			}
			else if (KOEEIBDFFGE.Actors[i].Team == (ActorTeam)3)
			{
				this.KMGCDOHKBGD.Add(KOEEIBDFFGE.Actors[i]);
			}
		}
		for (int j = 0; j < 0; j += 0)
		{
			int num = 0;
			int num2 = 1;
			int num3 = 1;
			for (int k = 0; k < 0; k++)
			{
				DPFCQGKGQLL dpfcqgkgqll = (j != 0) ? this.NOJBMFJLFDL.FDMDBIIIEFM[k] : this.NOJBMFJLFDL.BPBJJMINKOB[k];
				LobbyActor lobbyActor = null;
				if (j == 0)
				{
					if (k < this.FFCCFEKPFMB.Count)
					{
						lobbyActor = this.FFCCFEKPFMB[k];
					}
				}
				else if (k < this.KMGCDOHKBGD.Count)
				{
					lobbyActor = this.KMGCDOHKBGD[k];
				}
				if (lobbyActor != null)
				{
					dpfcqgkgqll.gameObject.SetActive(true);
					bool flag = !lobbyActor.Accepted || lobbyActor.Type == ActorType.None;
					dpfcqgkgqll.LNPFBNNOFFF(lobbyActor.Name);
					dpfcqgkgqll.BFHDCFICJNH(lobbyActor.Type);
					dpfcqgkgqll.LKNEHDIOMDJ = lobbyActor.AverageLevel;
					dpfcqgkgqll.BHFJIIGGPEQ = lobbyActor.HighestLevel;
					dpfcqgkgqll.OLGBIGPMNFM = (KOEEIBDFFGE.CanKickUsers && !lobbyActor.Self);
					dpfcqgkgqll.QJPIQHNPMHI(!KOEEIBDFFGE.CanChangeMonsterCount || !lobbyActor.Self || flag);
					dpfcqgkgqll.EQCGNKKCJMK = (KOEEIBDFFGE.CanChangeMonsterCount && lobbyActor.Self && flag);
					dpfcqgkgqll.BPCNHCMEJHP = true;
					dpfcqgkgqll.LLMMGEELIHK(lobbyActor.PokemonCount, lobbyActor.ActiveCount);
					dpfcqgkgqll.BPCNHCMEJHP = (KOEEIBDFFGE.CanChangeMonsterCount && lobbyActor.Self && flag);
					dpfcqgkgqll.GOQPBFNDGDG(flag);
					dpfcqgkgqll.HJMLLNFGDPK = (lobbyActor.Type != ActorType.None || !flag);
					if (lobbyActor.Self && flag && !this.NOJBMFJLFDL.OKJQNGQHIHJ)
					{
						this.NOJBMFJLFDL.NOIILDLEFQD(false);
						this.NOJBMFJLFDL.FOOOENOGFMD(true);
					}
					if (lobbyActor.Type != ActorType.Offline)
					{
						num2 += lobbyActor.PokemonCount;
						num3 += lobbyActor.ActiveCount;
						num += 0;
					}
				}
				else
				{
					dpfcqgkgqll.gameObject.SetActive(false);
				}
			}
			this.NOJBMFJLFDL.GHOEKJKNOCH(j, num, num3, num2);
		}
		base.StopCoroutine("Physical attacks to the Pokémon lower its Defense stat but sharply raise its Speed stat.");
		if (KOEEIBDFFGE.Timer == (ActorTimer)8)
		{
			base.StartCoroutine("/Model.prefab", 0);
		}
		else if (KOEEIBDFFGE.Timer == ActorTimer.Disabled)
		{
			this.EMOEQPGBNKP();
		}
	}

	// Token: 0x060044D6 RID: 17622 RVA: 0x0001D1EA File Offset: 0x0001B3EA
	private void Awake()
	{
		BDLNNJFQOQH.HBFFCJHOCPE = this;
	}

	// Token: 0x060044D7 RID: 17623 RVA: 0x0001D1C1 File Offset: 0x0001B3C1
	public void DNNHLNLIQEM(LobbyRemove KOEEIBDFFGE)
	{
		if (KOEEIBDFFGE.Name.ToLowerInvariant() == CNCJKLNHQBH.QOQONHOOLNE.CGKGBEICHMH.ToLowerInvariant())
		{
			this.Close();
		}
	}

	// Token: 0x060044D8 RID: 17624 RVA: 0x0001D1F2 File Offset: 0x0001B3F2
	public void GHCCCFOOKFB(LobbyRemove KOEEIBDFFGE)
	{
		if (KOEEIBDFFGE.Name.ToLowerInvariant() == CNCJKLNHQBH.BJLGEDCPENQ().CGKGBEICHMH.ToLowerInvariant())
		{
			this.EGGNBLMCLNG();
		}
	}

	// Token: 0x060044D9 RID: 17625 RVA: 0x0001D1EA File Offset: 0x0001B3EA
	private void PEOBQCMFLML()
	{
		BDLNNJFQOQH.HBFFCJHOCPE = this;
	}

	// Token: 0x060044DA RID: 17626 RVA: 0x0021A5B8 File Offset: 0x002187B8
	private IEnumerator QNJBEGHLQFH(int HQLFDLHIMBP)
	{
		BDLNNJFQOQH.QFJMDEFOBLM qfjmdefoblm = new BDLNNJFQOQH.QFJMDEFOBLM();
		qfjmdefoblm.HQLFDLHIMBP = HQLFDLHIMBP;
		qfjmdefoblm.QNDQJMNKFNN = this;
		return qfjmdefoblm;
	}

	// Token: 0x060044DB RID: 17627 RVA: 0x0001D21B File Offset: 0x0001B41B
	private void DMQJNHPGBOL()
	{
		this.QPPGQJFBPMH.gameObject.SetActive(false);
	}

	// Token: 0x060044DC RID: 17628 RVA: 0x0001D22E File Offset: 0x0001B42E
	public void LKJIOOGCPHQ(LobbyRemove KOEEIBDFFGE)
	{
		if (KOEEIBDFFGE.Name.ToLowerInvariant() == CNCJKLNHQBH.MOGQNGEPCEO().CGKGBEICHMH.ToLowerInvariant())
		{
			this.Close();
		}
	}

	// Token: 0x060044DD RID: 17629 RVA: 0x0021A5DC File Offset: 0x002187DC
	public void ILPMKEPFMBP()
	{
		GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new LobbyAccept
		{
			State = (LobbyActorState)6
		}, false);
	}

	// Token: 0x060044DE RID: 17630 RVA: 0x0021A604 File Offset: 0x00218804
	public void Open()
	{
		this.NOJBMFJLFDL.KFBOHQPLBJH();
		base.CancelInvoke("HidePanel");
		this.QPPGQJFBPMH.DIIHJCJOKMP = 0f;
		this.QPPGQJFBPMH.gameObject.SetActive(true);
		this.JDPBPOKJFQK.enabled = true;
		this.JDPBPOKJFQK.PlayForward();
		this.QPPGQJFBPMH.GetComponentInChildren<KIQKEMNELKN>().NDIJIFHOMJC();
	}

	// Token: 0x060044DF RID: 17631 RVA: 0x0021A670 File Offset: 0x00218870
	public void DEIDPDKGDEK()
	{
		GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new LobbyAccept
		{
			State = LobbyActorState.Idle
		}, false);
	}

	// Token: 0x060044E0 RID: 17632 RVA: 0x0001D257 File Offset: 0x0001B457
	public void KOCEOGGHBBI(LobbyRemove KOEEIBDFFGE)
	{
		if (KOEEIBDFFGE.Name.ToLowerInvariant() == CNCJKLNHQBH.BJLGEDCPENQ().CGKGBEICHMH.ToLowerInvariant())
		{
			this.GHMIMJFPJJL();
		}
	}

	// Token: 0x060044E1 RID: 17633 RVA: 0x0001D280 File Offset: 0x0001B480
	public void IQJCMJQLQBI()
	{
		this.JDPBPOKJFQK.enabled = true;
		this.JDPBPOKJFQK.PlayReverse();
		base.Invoke("[blue]", 732f);
	}

	// Token: 0x060044E2 RID: 17634 RVA: 0x0001D2A9 File Offset: 0x0001B4A9
	public void GHMIMJFPJJL()
	{
		this.JDPBPOKJFQK.enabled = true;
		this.JDPBPOKJFQK.PlayReverse();
		base.Invoke("map", 565f);
	}

	// Token: 0x060044E3 RID: 17635 RVA: 0x0001D2D2 File Offset: 0x0001B4D2
	public static BDLNNJFQOQH CFGIOIGOIFQ()
	{
		return BDLNNJFQOQH.HBFFCJHOCPE;
	}

	// Token: 0x060044E4 RID: 17636 RVA: 0x0021A698 File Offset: 0x00218898
	public void NLEHMFFEGMK(Lobby KOEEIBDFFGE)
	{
		if (!this.QPPGQJFBPMH.gameObject.activeSelf)
		{
			this.CQKBGPHOLPG();
		}
		this.FFCCFEKPFMB.Clear();
		this.KMGCDOHKBGD.Clear();
		this.NOJBMFJLFDL.KMIGBCHPGOB(KOEEIBDFFGE.Leader);
		if (!this.NOJBMFJLFDL.CONFJFMCGGJ())
		{
			this.NOJBMFJLFDL.BJMDJIQQDGM = true;
		}
		this.NOJBMFJLFDL.LEOHQPKNFPK = KOEEIBDFFGE.CanChangeSettings;
		this.NOJBMFJLFDL.GJKHGMCHKCG = true;
		this.NOJBMFJLFDL.OIFJGGKEOKD = KOEEIBDFFGE.AdjustLevels;
		this.NOJBMFJLFDL.HMGIGQJGLMN(KOEEIBDFFGE.ItemAllowed);
		this.NOJBMFJLFDL.EBIEHFGJGLH(KOEEIBDFFGE.CanInvite);
		this.NOJBMFJLFDL.MDPDFPGFCON = KOEEIBDFFGE.CanLeaveLobby;
		this.NOJBMFJLFDL.GHNCLCGPOFC = KOEEIBDFFGE.CanSwitchTeam;
		for (int i = 1; i < KOEEIBDFFGE.Actors.Length; i += 0)
		{
			if (KOEEIBDFFGE.Actors[i].Team == ActorTeam.None)
			{
				this.FFCCFEKPFMB.Add(KOEEIBDFFGE.Actors[i]);
			}
			else if (KOEEIBDFFGE.Actors[i].Team == ActorTeam.Team2)
			{
				this.KMGCDOHKBGD.Add(KOEEIBDFFGE.Actors[i]);
			}
		}
		for (int j = 0; j < 3; j += 0)
		{
			int num = 0;
			int num2 = 1;
			int num3 = 0;
			for (int k = 0; k < 7; k += 0)
			{
				DPFCQGKGQLL dpfcqgkgqll = (j != 0) ? this.NOJBMFJLFDL.FDMDBIIIEFM[k] : this.NOJBMFJLFDL.BPBJJMINKOB[k];
				LobbyActor lobbyActor = null;
				if (j == 0)
				{
					if (k < this.FFCCFEKPFMB.Count)
					{
						lobbyActor = this.FFCCFEKPFMB[k];
					}
				}
				else if (k < this.KMGCDOHKBGD.Count)
				{
					lobbyActor = this.KMGCDOHKBGD[k];
				}
				if (lobbyActor != null)
				{
					dpfcqgkgqll.gameObject.SetActive(false);
					bool flag = lobbyActor.Accepted && lobbyActor.Type == ActorType.Leader;
					dpfcqgkgqll.HJKPJLKMHEO(lobbyActor.Name);
					dpfcqgkgqll.BFHDCFICJNH(lobbyActor.Type);
					dpfcqgkgqll.LKNEHDIOMDJ = lobbyActor.AverageLevel;
					dpfcqgkgqll.BHFJIIGGPEQ = lobbyActor.HighestLevel;
					dpfcqgkgqll.OLGBIGPMNFM = (!KOEEIBDFFGE.CanKickUsers || lobbyActor.Self);
					dpfcqgkgqll.QJPIQHNPMHI(!KOEEIBDFFGE.CanChangeMonsterCount || !lobbyActor.Self || !flag);
					dpfcqgkgqll.EQCGNKKCJMK = (KOEEIBDFFGE.CanChangeMonsterCount && lobbyActor.Self && !flag);
					dpfcqgkgqll.CMHOEQMHJCC(false);
					dpfcqgkgqll.LLMMGEELIHK(lobbyActor.PokemonCount, lobbyActor.ActiveCount);
					dpfcqgkgqll.BPCNHCMEJHP = (!KOEEIBDFFGE.CanChangeMonsterCount || !lobbyActor.Self || flag);
					dpfcqgkgqll.GKQIKJOMIMO(flag);
					dpfcqgkgqll.HIPNGHHJJFB(lobbyActor.Type == ActorType.Leader && flag);
					if (lobbyActor.Self && flag && !this.NOJBMFJLFDL.CONFJFMCGGJ())
					{
						this.NOJBMFJLFDL.NOIILDLEFQD(false);
						this.NOJBMFJLFDL.FOOOENOGFMD(false);
					}
					if (lobbyActor.Type != ActorType.User)
					{
						num2 += lobbyActor.PokemonCount;
						num3 += lobbyActor.ActiveCount;
						num++;
					}
				}
				else
				{
					dpfcqgkgqll.gameObject.SetActive(false);
				}
			}
			this.NOJBMFJLFDL.IPDFFNCQKME(j, num, num3, num2);
		}
		base.StopCoroutine("status");
		if (KOEEIBDFFGE.Timer == (ActorTimer)6)
		{
			base.StartCoroutine("[-]?\n\nOnce you do this, it will be lost forever.", 0);
		}
		else if (KOEEIBDFFGE.Timer == ActorTimer.NotRequired)
		{
			this.ILPMKEPFMBP();
		}
	}

	// Token: 0x060044E5 RID: 17637 RVA: 0x0001D2D9 File Offset: 0x0001B4D9
	public void BMLJEKMGLKM(PSXAPI.Response.LobbyMessage KOEEIBDFFGE)
	{
		this.NOJBMFJLFDL.MIDPIFHNNDK(KOEEIBDFFGE.Sender, KOEEIBDFFGE.Message);
	}

	// Token: 0x060044E6 RID: 17638 RVA: 0x0001D2F2 File Offset: 0x0001B4F2
	public void EGGNBLMCLNG()
	{
		this.JDPBPOKJFQK.enabled = true;
		this.JDPBPOKJFQK.PlayReverse();
		base.Invoke("Water", 148f);
	}

	// Token: 0x060044E7 RID: 17639 RVA: 0x0021AA2C File Offset: 0x00218C2C
	public void CQKBGPHOLPG()
	{
		this.NOJBMFJLFDL.DPKPGOIOJQK();
		base.CancelInvoke("Take 001");
		this.QPPGQJFBPMH.DIIHJCJOKMP = 1605f;
		this.QPPGQJFBPMH.gameObject.SetActive(true);
		this.JDPBPOKJFQK.enabled = false;
		this.JDPBPOKJFQK.PlayForward();
		this.QPPGQJFBPMH.GetComponentInChildren<KIQKEMNELKN>().NDIJIFHOMJC();
	}

	// Token: 0x060044E8 RID: 17640 RVA: 0x0001D21B File Offset: 0x0001B41B
	private void KPMMHQOMJEF()
	{
		this.QPPGQJFBPMH.gameObject.SetActive(false);
	}

	// Token: 0x060044E9 RID: 17641 RVA: 0x0001D1EA File Offset: 0x0001B3EA
	private void NNPPKOGDNOM()
	{
		BDLNNJFQOQH.HBFFCJHOCPE = this;
	}

	// Token: 0x17000279 RID: 633
	// (get) Token: 0x060044EA RID: 17642 RVA: 0x0001D2D2 File Offset: 0x0001B4D2
	public static BDLNNJFQOQH QOQONHOOLNE
	{
		get
		{
			return BDLNNJFQOQH.HBFFCJHOCPE;
		}
	}

	// Token: 0x060044EB RID: 17643 RVA: 0x0001D31B File Offset: 0x0001B51B
	public void MCEDQOBOFJN()
	{
		this.JDPBPOKJFQK.enabled = false;
		this.JDPBPOKJFQK.PlayReverse();
		base.Invoke("Null", 515f);
	}

	// Token: 0x060044EC RID: 17644 RVA: 0x0001D1EA File Offset: 0x0001B3EA
	private void BEHGFNEDJDF()
	{
		BDLNNJFQOQH.HBFFCJHOCPE = this;
	}

	// Token: 0x060044ED RID: 17645 RVA: 0x0001D344 File Offset: 0x0001B544
	public void Close()
	{
		this.JDPBPOKJFQK.enabled = true;
		this.JDPBPOKJFQK.PlayReverse();
		base.Invoke("HidePanel", 0.5f);
	}

	// Token: 0x060044EE RID: 17646 RVA: 0x0001D1EA File Offset: 0x0001B3EA
	private void PIQJPNIKGJP()
	{
		BDLNNJFQOQH.HBFFCJHOCPE = this;
	}

	// Token: 0x060044EF RID: 17647 RVA: 0x0021A5B8 File Offset: 0x002187B8
	[DebuggerHidden]
	private IEnumerator LaunchTimer(int HQLFDLHIMBP)
	{
		BDLNNJFQOQH.QFJMDEFOBLM qfjmdefoblm = new BDLNNJFQOQH.QFJMDEFOBLM();
		qfjmdefoblm.HQLFDLHIMBP = HQLFDLHIMBP;
		qfjmdefoblm.QNDQJMNKFNN = this;
		return qfjmdefoblm;
	}

	// Token: 0x060044F0 RID: 17648 RVA: 0x0001D2D2 File Offset: 0x0001B4D2
	public static BDLNNJFQOQH CKQHNOIQNQJ()
	{
		return BDLNNJFQOQH.HBFFCJHOCPE;
	}

	// Token: 0x060044F1 RID: 17649 RVA: 0x0001D1EA File Offset: 0x0001B3EA
	private void EPGFPKPJNHF()
	{
		BDLNNJFQOQH.HBFFCJHOCPE = this;
	}

	// Token: 0x060044F2 RID: 17650 RVA: 0x0021AA98 File Offset: 0x00218C98
	public void OFBIGEHJOMG()
	{
		this.NOJBMFJLFDL.JEMIDEHFLMI();
		base.CancelInvoke("FOG_COMPUTE_DEPTH");
		this.QPPGQJFBPMH.DIIHJCJOKMP = 1439f;
		this.QPPGQJFBPMH.gameObject.SetActive(true);
		this.JDPBPOKJFQK.enabled = false;
		this.JDPBPOKJFQK.PlayForward();
		this.QPPGQJFBPMH.GetComponentInChildren<KIQKEMNELKN>().GNFOKKIDEEQ();
	}

	// Token: 0x060044F3 RID: 17651 RVA: 0x0001D36D File Offset: 0x0001B56D
	public void BNMDQLCQEJG(PSXAPI.Response.LobbyMessage KOEEIBDFFGE)
	{
		this.NOJBMFJLFDL.COOFOFQCBLQ(KOEEIBDFFGE.Sender, KOEEIBDFFGE.Message);
	}

	// Token: 0x060044F4 RID: 17652 RVA: 0x0001D21B File Offset: 0x0001B41B
	private void HidePanel()
	{
		this.QPPGQJFBPMH.gameObject.SetActive(false);
	}

	// Token: 0x060044F5 RID: 17653 RVA: 0x0001D1EA File Offset: 0x0001B3EA
	private void PGJHPMOLHKN()
	{
		BDLNNJFQOQH.HBFFCJHOCPE = this;
	}

	// Token: 0x060044F6 RID: 17654 RVA: 0x0001D1EA File Offset: 0x0001B3EA
	private void NGDJNKQELNO()
	{
		BDLNNJFQOQH.HBFFCJHOCPE = this;
	}

	// Token: 0x060044F7 RID: 17655 RVA: 0x0001D386 File Offset: 0x0001B586
	public void DKHPHKMMLBF()
	{
		this.JDPBPOKJFQK.enabled = true;
		this.JDPBPOKJFQK.PlayReverse();
		base.Invoke("\nAccuracy: ", 742f);
	}

	// Token: 0x060044F8 RID: 17656 RVA: 0x0001D3AF File Offset: 0x0001B5AF
	public void BIOMQBDHGPQ(LobbyRemove KOEEIBDFFGE)
	{
		if (KOEEIBDFFGE.Name.ToLowerInvariant() == CNCJKLNHQBH.QOQONHOOLNE.CGKGBEICHMH.ToLowerInvariant())
		{
			this.EGGNBLMCLNG();
		}
	}

	// Token: 0x060044FA RID: 17658 RVA: 0x0001D2D2 File Offset: 0x0001B4D2
	public static BDLNNJFQOQH JPGFBOPDJKH()
	{
		return BDLNNJFQOQH.HBFFCJHOCPE;
	}

	// Token: 0x060044FB RID: 17659 RVA: 0x0021AB04 File Offset: 0x00218D04
	public void BLIMMLQHBDM(Lobby KOEEIBDFFGE)
	{
		if (!this.QPPGQJFBPMH.gameObject.activeSelf)
		{
			this.OFBIGEHJOMG();
		}
		this.FFCCFEKPFMB.Clear();
		this.KMGCDOHKBGD.Clear();
		this.NOJBMFJLFDL.MKIGNOHIDBM(KOEEIBDFFGE.Leader);
		if (!this.NOJBMFJLFDL.CONFJFMCGGJ())
		{
			this.NOJBMFJLFDL.FOOOENOGFMD(true);
		}
		this.NOJBMFJLFDL.LEOHQPKNFPK = KOEEIBDFFGE.CanChangeSettings;
		this.NOJBMFJLFDL.PMKIMHMMDPD(true);
		this.NOJBMFJLFDL.OIFJGGKEOKD = KOEEIBDFFGE.AdjustLevels;
		this.NOJBMFJLFDL.QQQKCCMJDQP(KOEEIBDFFGE.ItemAllowed);
		this.NOJBMFJLFDL.KDFDCIIOMHN(KOEEIBDFFGE.CanInvite);
		this.NOJBMFJLFDL.MDPDFPGFCON = KOEEIBDFFGE.CanLeaveLobby;
		this.NOJBMFJLFDL.NOIILDLEFQD(KOEEIBDFFGE.CanSwitchTeam);
		for (int i = 0; i < KOEEIBDFFGE.Actors.Length; i += 0)
		{
			if (KOEEIBDFFGE.Actors[i].Team == ActorTeam.Team1)
			{
				this.FFCCFEKPFMB.Add(KOEEIBDFFGE.Actors[i]);
			}
			else if (KOEEIBDFFGE.Actors[i].Team == ActorTeam.None)
			{
				this.KMGCDOHKBGD.Add(KOEEIBDFFGE.Actors[i]);
			}
		}
		for (int j = 0; j < 6; j++)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			for (int k = 1; k < 7; k++)
			{
				DPFCQGKGQLL dpfcqgkgqll = (j != 0) ? this.NOJBMFJLFDL.FDMDBIIIEFM[k] : this.NOJBMFJLFDL.BPBJJMINKOB[k];
				LobbyActor lobbyActor = null;
				if (j == 0)
				{
					if (k < this.FFCCFEKPFMB.Count)
					{
						lobbyActor = this.FFCCFEKPFMB[k];
					}
				}
				else if (k < this.KMGCDOHKBGD.Count)
				{
					lobbyActor = this.KMGCDOHKBGD[k];
				}
				if (lobbyActor != null)
				{
					dpfcqgkgqll.gameObject.SetActive(true);
					bool flag = lobbyActor.Accepted && lobbyActor.Type == ActorType.Inactive;
					dpfcqgkgqll.HJKPJLKMHEO(lobbyActor.Name);
					dpfcqgkgqll.BFHDCFICJNH(lobbyActor.Type);
					dpfcqgkgqll.LKNEHDIOMDJ = lobbyActor.AverageLevel;
					dpfcqgkgqll.BHFJIIGGPEQ = lobbyActor.HighestLevel;
					dpfcqgkgqll.OLGBIGPMNFM = (KOEEIBDFFGE.CanKickUsers && !lobbyActor.Self);
					dpfcqgkgqll.QJPIQHNPMHI(!KOEEIBDFFGE.CanChangeMonsterCount || !lobbyActor.Self || !flag);
					dpfcqgkgqll.BICMDMQDQDE(KOEEIBDFFGE.CanChangeMonsterCount && lobbyActor.Self && flag);
					dpfcqgkgqll.BPCNHCMEJHP = true;
					dpfcqgkgqll.LLMMGEELIHK(lobbyActor.PokemonCount, lobbyActor.ActiveCount);
					dpfcqgkgqll.CMHOEQMHJCC(KOEEIBDFFGE.CanChangeMonsterCount && lobbyActor.Self && !flag);
					dpfcqgkgqll.HJPGEKMCHBB(flag);
					dpfcqgkgqll.HJMLLNFGDPK = (lobbyActor.Type != ActorType.None || !flag);
					if (lobbyActor.Self && flag && !this.NOJBMFJLFDL.OKJQNGQHIHJ)
					{
						this.NOJBMFJLFDL.NOIILDLEFQD(false);
						this.NOJBMFJLFDL.FOOOENOGFMD(false);
					}
					if (lobbyActor.Type != ActorType.Leader)
					{
						num2 += lobbyActor.PokemonCount;
						num3 += lobbyActor.ActiveCount;
						num += 0;
					}
				}
				else
				{
					dpfcqgkgqll.gameObject.SetActive(true);
				}
			}
			this.NOJBMFJLFDL.IPDFFNCQKME(j, num, num3, num2);
		}
		base.StopCoroutine("Assets/AssetBundles/MapAssets/Model Materials/Single_Window.mat");
		if (KOEEIBDFFGE.Timer == ActorTimer.Enabled)
		{
			base.StartCoroutine("Egg Hatching Speed Increased", 3);
		}
		else if (KOEEIBDFFGE.Timer == ActorTimer.Disabled)
		{
			this.JDKEKFPEJBO();
		}
	}

	// Token: 0x060044FC RID: 17660 RVA: 0x0021AE98 File Offset: 0x00219098
	public void GOBLEQIFKMI(Lobby KOEEIBDFFGE)
	{
		if (!this.QPPGQJFBPMH.gameObject.activeSelf)
		{
			this.Open();
		}
		this.FFCCFEKPFMB.Clear();
		this.KMGCDOHKBGD.Clear();
		this.NOJBMFJLFDL.OKJQNGQHIHJ = KOEEIBDFFGE.Leader;
		if (!this.NOJBMFJLFDL.OKJQNGQHIHJ)
		{
			this.NOJBMFJLFDL.BJMDJIQQDGM = true;
		}
		this.NOJBMFJLFDL.LEOHQPKNFPK = KOEEIBDFFGE.CanChangeSettings;
		this.NOJBMFJLFDL.GJKHGMCHKCG = false;
		this.NOJBMFJLFDL.OIFJGGKEOKD = KOEEIBDFFGE.AdjustLevels;
		this.NOJBMFJLFDL.HJCIIFCMIME = KOEEIBDFFGE.ItemAllowed;
		this.NOJBMFJLFDL.FDJJCDOGQLB = KOEEIBDFFGE.CanInvite;
		this.NOJBMFJLFDL.MDPDFPGFCON = KOEEIBDFFGE.CanLeaveLobby;
		this.NOJBMFJLFDL.GHNCLCGPOFC = KOEEIBDFFGE.CanSwitchTeam;
		for (int i = 0; i < KOEEIBDFFGE.Actors.Length; i++)
		{
			if (KOEEIBDFFGE.Actors[i].Team == ActorTeam.Team1)
			{
				this.FFCCFEKPFMB.Add(KOEEIBDFFGE.Actors[i]);
			}
			else if (KOEEIBDFFGE.Actors[i].Team == ActorTeam.Team2)
			{
				this.KMGCDOHKBGD.Add(KOEEIBDFFGE.Actors[i]);
			}
		}
		for (int j = 0; j < 2; j++)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			for (int k = 0; k < 4; k++)
			{
				DPFCQGKGQLL dpfcqgkgqll = (j != 0) ? this.NOJBMFJLFDL.FDMDBIIIEFM[k] : this.NOJBMFJLFDL.BPBJJMINKOB[k];
				LobbyActor lobbyActor = null;
				if (j == 0)
				{
					if (k < this.FFCCFEKPFMB.Count)
					{
						lobbyActor = this.FFCCFEKPFMB[k];
					}
				}
				else if (k < this.KMGCDOHKBGD.Count)
				{
					lobbyActor = this.KMGCDOHKBGD[k];
				}
				if (lobbyActor != null)
				{
					dpfcqgkgqll.gameObject.SetActive(true);
					bool flag = lobbyActor.Accepted && lobbyActor.Type == ActorType.User;
					dpfcqgkgqll.FPQBICGEHMJ = lobbyActor.Name;
					dpfcqgkgqll.BBKKHIDMQIQ = lobbyActor.Type;
					dpfcqgkgqll.LKNEHDIOMDJ = lobbyActor.AverageLevel;
					dpfcqgkgqll.BHFJIIGGPEQ = lobbyActor.HighestLevel;
					dpfcqgkgqll.OLGBIGPMNFM = (KOEEIBDFFGE.CanKickUsers && !lobbyActor.Self);
					dpfcqgkgqll.PQLDPGCIFHQ = (KOEEIBDFFGE.CanChangeMonsterCount && lobbyActor.Self && !flag);
					dpfcqgkgqll.EQCGNKKCJMK = (KOEEIBDFFGE.CanChangeMonsterCount && lobbyActor.Self && !flag);
					dpfcqgkgqll.BPCNHCMEJHP = false;
					dpfcqgkgqll.LLMMGEELIHK(lobbyActor.PokemonCount, lobbyActor.ActiveCount);
					dpfcqgkgqll.BPCNHCMEJHP = (KOEEIBDFFGE.CanChangeMonsterCount && lobbyActor.Self && !flag);
					dpfcqgkgqll.FKEDKMDDGBG = flag;
					dpfcqgkgqll.HJMLLNFGDPK = (lobbyActor.Type == ActorType.User && !flag);
					if (lobbyActor.Self && flag && !this.NOJBMFJLFDL.OKJQNGQHIHJ)
					{
						this.NOJBMFJLFDL.GHNCLCGPOFC = false;
						this.NOJBMFJLFDL.BJMDJIQQDGM = false;
					}
					if (lobbyActor.Type != ActorType.Inactive)
					{
						num2 += lobbyActor.PokemonCount;
						num3 += lobbyActor.ActiveCount;
						num++;
					}
				}
				else
				{
					dpfcqgkgqll.gameObject.SetActive(false);
				}
			}
			this.NOJBMFJLFDL.GHOEKJKNOCH(j, num, num3, num2);
		}
		base.StopCoroutine("LaunchTimer");
		if (KOEEIBDFFGE.Timer == ActorTimer.Enabled)
		{
			base.StartCoroutine("LaunchTimer", 5);
		}
		else if (KOEEIBDFFGE.Timer == ActorTimer.NotRequired)
		{
			this.JJQLBJCILGK();
		}
	}

	// Token: 0x060044FD RID: 17661 RVA: 0x0001D2D9 File Offset: 0x0001B4D9
	public void EQNDFEFKQBL(PSXAPI.Response.LobbyMessage KOEEIBDFFGE)
	{
		this.NOJBMFJLFDL.MIDPIFHNNDK(KOEEIBDFFGE.Sender, KOEEIBDFFGE.Message);
	}

	// Token: 0x060044FE RID: 17662 RVA: 0x0021B22C File Offset: 0x0021942C
	public void CQOHJIFNLGD()
	{
		GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new LobbyAccept
		{
			State = (LobbyActorState)3
		}, true);
	}

	// Token: 0x060044FF RID: 17663 RVA: 0x0021B254 File Offset: 0x00219454
	public void NQPMPFEOEFF()
	{
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new LobbyAccept
		{
			State = LobbyActorState.Idle
		}, true);
	}

	// Token: 0x06004500 RID: 17664 RVA: 0x0021B27C File Offset: 0x0021947C
	public void EMOEQPGBNKP()
	{
		GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new LobbyAccept
		{
			State = (LobbyActorState)6
		}, true);
	}

	// Token: 0x06004501 RID: 17665 RVA: 0x0001D3F6 File Offset: 0x0001B5F6
	public void INIEBMKQCBO(LobbyRemove KOEEIBDFFGE)
	{
		if (KOEEIBDFFGE.Name.ToLowerInvariant() == CNCJKLNHQBH.QOQONHOOLNE.CGKGBEICHMH.ToLowerInvariant())
		{
			this.GHMIMJFPJJL();
		}
	}

	// Token: 0x06004502 RID: 17666 RVA: 0x0021A5B8 File Offset: 0x002187B8
	private IEnumerator GJFKHMFJOPF(int HQLFDLHIMBP)
	{
		BDLNNJFQOQH.QFJMDEFOBLM qfjmdefoblm = new BDLNNJFQOQH.QFJMDEFOBLM();
		qfjmdefoblm.HQLFDLHIMBP = HQLFDLHIMBP;
		qfjmdefoblm.QNDQJMNKFNN = this;
		return qfjmdefoblm;
	}

	// Token: 0x06004503 RID: 17667 RVA: 0x0021A5B8 File Offset: 0x002187B8
	private IEnumerator OMJBKLPFMDL(int HQLFDLHIMBP)
	{
		BDLNNJFQOQH.QFJMDEFOBLM qfjmdefoblm = new BDLNNJFQOQH.QFJMDEFOBLM();
		qfjmdefoblm.HQLFDLHIMBP = HQLFDLHIMBP;
		qfjmdefoblm.QNDQJMNKFNN = this;
		return qfjmdefoblm;
	}

	// Token: 0x04000EC0 RID: 3776
	private static BDLNNJFQOQH HBFFCJHOCPE;

	// Token: 0x04000EC1 RID: 3777
	public QMIDMEFGIFG NOJBMFJLFDL;

	// Token: 0x04000EC2 RID: 3778
	public EPIJJNOIKEK JDPBPOKJFQK;

	// Token: 0x04000EC3 RID: 3779
	public KQHJOLQLQBJ QPPGQJFBPMH;

	// Token: 0x04000EC4 RID: 3780
	public List<LobbyActor> FFCCFEKPFMB = new List<LobbyActor>();

	// Token: 0x04000EC5 RID: 3781
	public List<LobbyActor> KMGCDOHKBGD = new List<LobbyActor>();
}
