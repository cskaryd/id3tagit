namespace ID3_TagIT
{
  using Microsoft.VisualBasic.CompilerServices;
  using System;
  using System.Collections;
  using System.Runtime.InteropServices;

  [StandardModule]
  internal sealed class Declarations
  {
    public static int[] aintAllowedBitrates = new int[] {
            8, 0x10, 0x18, 0x20, 40, 0x30, 0x38, 0x40, 80, 0x60, 0x70, 0x80, 160, 0xc0, 0xe0, 0x100,
            320, 0x180, 0x1a0, 0x1c0
        };
    public static int[,] aintBitrateLookup = new int[8, 0x10];
    public static int[,] aintFreqLookup = new int[4, 8];
    public static float[] asinBaseLenLayer1 = new float[4];
    public static float[] asinBaseLenLayer23 = new float[4];
    public static string[] astrDefinedFrames = new string[0x5d];
    public static string[] astrGenreLookup = new string[0x94];
    public static string[] astrLanLookup;
    public const short FO_COPY = 2;
    public const short FO_DELETE = 3;
    public const short FO_MOVE = 1;
    public const short FO_RENAME = 4;
    public const int FOF_ALLOWUNDO = 0x40;
    public const int FOF_CONFIRMMOUSE = 2;
    public const int FOF_FILESONLY = 0x80;
    public const int FOF_MULTIDESTFILES = 1;
    public const int FOF_NOCONFIRMATION = 0x10;
    public const int FOF_NOCONFIRMMKDIR = 0x200;
    public const int FOF_RENAMEONCOLLISION = 8;
    public const int FOF_SILENT = 4;
    public const int FOF_SIMPLEPROGRESS = 0x100;
    public const int FOF_WANTMAPPINGHANDLE = 0x20;
    public const int HDM_SETIMAGELIST = 0x1208;
    public const int LVCF_FMT = 1;
    public const int LVCF_IMAGE = 0x10;
    public const int LVCFMT_BITMAP_ON_RIGHT = 0x1000;
    public const int LVCFMT_IMAGE = 0x800;
    public const int LVCFMT_LEFT = 0;
    public const int LVCFMT_RIGHT = 1;
    public const int LVM_GETHEADER = 0x101f;
    public const int LVM_SETCOLUMN = 0x101a;
    public static ArrayList MP3s = new ArrayList();
    public static Resources objResources = new Resources();
    public static Settings objSettings = new Settings();
    public static ArrayList REDOList = new ArrayList();
    public const int SEE_MASK_FLAG_NO_UI = 0x400;
    public const int SEE_MASK_INVOKEIDLIST = 12;
    public const int SEE_MASK_NOCLOSEPROCESS = 0x40;
    public static ArrayList TempFiles = new ArrayList();
    public static ArrayList UNDOList = new ArrayList();
    public static string vstrCommonAppData = (Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + @"\ID3-TagIT 3\");
    public static string vstrUserAppData = (Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\ID3-TagIT 3\");

    public static void Declaration()
    {
      string str = "";
      string str3 = "";
      string str4 = "";
      string str2 = "";
      string str5 = "";
      str = (((((((str + "999,999,999,999,999,999," + "032,032,032,032,008,008,") + "064,048,040,048,016,016," + "096,056,048,056,024,024,") + "128,064,056,064,032,032," + "160,080,064,080,040,040,") + "192,096,080,096,048,048," + "224,112,096,112,056,056,") + "256,128,112,128,064,064," + "288,160,128,144,080,080,") + "320,192,160,160,096,096," + "352,224,192,176,112,112,") + "384,256,224,192,128,128," + "416,320,256,224,144,144,") + "448,384,320,256,160,160," + "999,999,999,999,999,999,";
      str3 = (str3 + "44100,22050,11025," + "48000,24000,12000,") + "32000,16000,08000," + "99999,99999,99999,";
      str4 = ((((((str4 + "Blues,Classic Rock,Country,Dance,Disco,Funk,Grunge,Hip-Hop,Jazz,Metal,New Age,") + "Oldies,Other,Pop,R&B,Rap,Reggae,Rock,Techno,Industrial,Alternative,Ska," + "Death Metal,Pranks,Soundtrack,Euro-Techno,Ambient,Trip-Hop,Vocal,Jazz+Funk,Fusion,Trance,Classical,") + "Instrumental,Acid,House,Game,Sound Clip,Gospel,Noise,AlternRock,Bass,Soul,Punk," + "Space,Meditative,Instrumental Pop,Instrumental Rock,Ethnic,Gothic,Darkwave,Techno-Industrial,Electronic,Pop-Folk,Eurodance,") + "Dream,Southern Rock,Comedy,Cult,Gangsta,Top 40,Christian Rap,Pop & Funk,Jungle,Native American,Cabaret," + "New Wave,Psychadelic,Rave,Showtunes,Trailer,Lo-Fi,Tribal,Acid Punk,Acid Jazz,Polka,Retro,") + "Musical,Rock & Roll,Hard Rock,Folk,Folk-Rock,National Folk,Swing,Fast Fusion,Bebop,Latin,Revival," + "Celtic,Bluegrass,Avantgarde,Gothic Rock,Progressive Rock,Psychedelic Rock,Symphonic Rock,Slow Rock,Big Band,Chorus,Easy Listening,") + "Acoustic,Humour,Speech,Chanson,Opera,Chamber Music,Sonata,Symphony,Booty Bass,Primus,Porn Groove," + "Satire,Slow Jam,Club,Tango,Samba,Folklore,Ballad,Power Ballad,Rhythmic Soul,Freestyle,Duet,") + "Punk Rock,Drum Solo,A capella,Euro-House,Dance Hall,Goa,Drum & Bass,Club-House,Hardcore,Terror,Indie,BritPop,Negerpunk,Polsk Punk," + "Beat,Christian Gangsta,Heavy Metal,Black Metal,Crossover,Contemporary C,Christian Rock,Merengue,Salsa,Thrash Metal,Anime,JPop,SynthPop";
      str2 = (str2 + "TPE1,TPE2,TPE3,TPE4,TIT1,TIT2,TIT3,COMM,TALB,TRCK,TBPM,TCOM,TCON,TCOP,TDAT,TDLY,TENC,TEXT,TFLT,TIME,TKEY,TLAN,TLEN,TMED,TOAL," + "TRDA,TRSN,TRSO,TSIZ,TSRC,TSSE,TYER,TXXX,WCOM,WCOP,WOAF,WOAR,WOAS,WORS,WPAY,WPUB,WXXX,TOPE,TORY,TOWN,TPOS,TPUB,TOFN,TOLY,USLT,") + "AENC,APIC,COMR,ENCR,EQUA,ETCO,GEOB,GRID,IPLS,LINK,MCDI,MLLT,OWNE,PRIV,PCNT,POPM,POSS,RBUF,RVAD,RVRB,SYLT,SYTC,UFID,USER," + "ASPI,EQU2,RVA2,SEEK,SIGN,TDEN,TDOR,TDRC,TDRL,TDTG,TIPL,TMCL,TMOO,TPRO,TSOA,TSOP,TSOT,TSST,";
      str5 = "ach - Acoli;ada - Adangme;afa - Afro-Asiatic (Other);afh - Afrihili;afr - Afrikaans;aka - Akan;akk - Akkadian;alb - Albanian;ale - Aleut;alg - Algonquian Languages;amh - Amharic;ang - English, Old (ca. 450-1100);apa - Apache Languages;ara - Arabic;arc - Aramaic;arm - Armenian;arn - Araucanian;arp - Arapaho;art - Artificial (Other);arw - Arawak;asm - Assamese;ath - Athapascan Languages;ava - Avaric;ave - Avestan;awa - Awadhi;aym - Aymara;aze - Azerbaijani;bad - Banda;bai - Bamileke Languages;bak - Bashkir;bal - Baluchi;bam - Bambara;ban - Balinese;baq - Basque;bas - Basa;bat - Baltic (Other);bej - Beja;bel - Byelorussian;bem - Bemba;ben - Bengali;ber - Berber (Other);bho - Bhojpuri;bih - Bihari;bik - Bikol;bin - Bini;bis - Bislama;bla - Siksika;bnt - Bantu (Other);bod - Tibetan;bra - Braj;bre - Breton;bua - Buriat;bug - Buginese;bul - Bulgarian;bur - Burmese;cad - Caddo;cai - Central American Indian (Other);car - Carib;cat - Catalan;cau - Caucasian (Other);";
      str5 = (((str5 + "ceb - Cebuano;cel - Celtic (Other);ces - Czech;cha - Chamorro;chb - Chibcha;che - Chechen;chg - Chagatai;chi - Chinese;chm - Mari;chn - Chinook jargon;cho - Choctaw;chr - Cherokee;chu - Church Slavic;chv - Chuvash;chy - Cheyenne;cop - Coptic;cor - Cornish;cos - Corsican;cpe - Creoles and Pidgins, English-based (Other);cpf - Creoles and Pidgins, French-based (Other);cpp - Creoles and Pidgins, Portuguese-based (Other);cre - Cree;crp - Creoles and Pidgins (Other);cus - Cushitic (Other);cym - Welsh;cze - Czech;dak - Dakota;dan - Danish;del - Delaware;deu - German;din - Dinka;div - Divehi;doi - Dogri;dra - Dravidian (Other);dua - Duala;dum - Dutch, Middle (ca. 1050-1350);dut - Dutch;dyu - Dyula;dzo - Dzongkha;efi - Efik;egy - Egyptian (Ancient);eka - Ekajuk;ell - Greek, Modern (1453-);elx - Elamite;eng - English;enm - English, Middle (ca. 1100-1500);epo - Esperanto;esk - Eskimo (Other);esl - Spanish;est - Estonian;" + "eus - Basque;ewe - Ewe;ewo - Ewondo;fan - Fang;fao - Faroese;fas - Persian;fat - Fanti;fij - Fijian;fin - Finnish;fiu - Finno-Ugrian (Other);fon - Fon;fra - French;fre - French;frm - French, Middle (ca. 1400-1600);fro - French, Old (842- ca. 1400);fry - Frisian;ful - Fulah;gaa - Ga;gae - Gaelic (Scots);gai - Irish;gay - Gayo;gdh - Gaelic (Scots);gem - Germanic (Other);geo - Georgian;ger - German;gez - Geez;gil - Gilbertese;glg - Gallegan;gmh - German, Middle High (ca. 1050-1500);goh - German, Old High (ca. 750-1050);gon - Gondi;got - Gothic;grb - Grebo;grc - Greek, Ancient (to 1453);gre - Greek, Modern (1453-);grn - Guarani;guj - Gujarati;hai - Haida;hau - Hausa;haw - Hawaiian;") + "heb - Hebrew;her - Herero;hil - Hiligaynon;him - Himachali;hin - Hindi;hmo - Hiri Motu;hun - Hungarian;hup - Hupa;hye - Armenian;iba - Iban;ibo - Igbo;ice - Icelandic;ijo - Ijo;iku - Inuktitut;ilo - Iloko;ina - Interlingua (International Auxiliary language Association);inc - Indic (Other);ind - Indonesian;ine - Indo-European (Other);ipk - Inupiak;ira - Iranian (Other);iri - Irish;iro - Iroquoian uages;isl - Icelandic;ita - Italian;jav - Javanese;jaw - Javanese;jpn - Japanese;jpr - Judeo-Persian;jrb - Judeo-Arabic;kaa - Kara-Kalpak;kab - Kabyle;kac - Kachin;kal - Greenlandic;kam - Kamba;kan - Kannada;kar - Karen;kas - Kashmiri;kat - Georgian;kau - Kanuri;kaw - Kawi;kaz - Kazakh;kha - Khasi;khi - Khoisan (Other);khm - Khmer;kho - Khotanese;kik - Kikuyu;kin - Kinyarwanda;kir - Kirghiz;kok - Konkani;" + "kom - Komi;kon - Kongo;kor - Korean;kpe - Kpelle;kro - Kru;kru - Kurukh;kua - Kuanyama;kum - Kumyk;kur - Kurdish;kus - Kusaie;kut - Kutenai;lad - Ladino;lah - Lahnda;lam - Lamba;lao - Lao;lat - Latin;lav - Latvian;lez - Lezghian;lin - Lingala;lit - Lithuanian;lol - Mongo;loz - Lozi;ltz - Letzeburgesch;lub - Luba-Katanga;lug - Ganda;lui - Luiseno;lun - Lunda;luo - Luo (Kenya and Tanzania);mac - Macedonian;mad - Madurese;mag - Magahi;mah - Marshall;mai - Maithili;mak - Makasar;mal - Malayalam;man - Mandingo;mao - Maori;map - Austronesian (Other);mar - Marathi;mas - Masai;max - Manx;may - Malay;men - Mende;mga - Irish, Middle (900 - 1200);mic - Micmac;min - Minangkabau;mis - Miscellaneous (Other);mkh - Mon-Kmer (Other);mlg - Malagasy;mlt - Maltese;") + "mni - Manipuri;mno - Manobo Languages;moh - Mohawk;mol - Moldavian;mon - Mongolian;mos - Mossi;mri - Maori;msa - Malay;mul - Multiple Languages;mun - Munda Languages;mus - Creek;mwr - Marwari;mya - Burmese;myn - Mayan Languages;nah - Aztec;nai - North American Indian (Other);nau - Nauru;nav - Navajo;nbl - Ndebele, South;nde - Ndebele, North;ndo - Ndongo;nep - Nepali;new - Newari;nic - Niger-Kordofanian (Other);niu - Niuean;nla - Dutch;nno - Norwegian (Nynorsk);non - Norse, Old;nor - Norwegian;nso - Sotho, Northern ;nub - Nubian Languages;nya - Nyanja;nym - Nyamwezi;nyn - Nyankole;nyo - Nyoro;nzi - Nzima;oci - Langue d'Oc (post 1500);oji - Ojibwa;ori - Oriya;orm - Oromo;osa - Osage;oss - Ossetic;ota - Turkish, Ottoman (1500 - 1928);oto - Otomian Languages;paa - Papuan-Australian (Other);pag - Pangasinan;pal - Pahlavi;pam - Pampanga;pan - Panjabi;pap - Papiamento;" + "pau - Palauan;peo - Persian, Old (ca 600 - 400 B.C.);per - Persian;phn - Phoenician;pli - Pali;pol - Polish;pon - Ponape;por - Portuguese;pra - Prakrit uages;pro - Provencal, Old (to 1500);pus - Pushto;que - Quechua;raj - Rajasthani;rar - Rarotongan;roa - Romance (Other);roh - Rhaeto-Romance;rom - Romany;ron - Romanian;rum - Romanian;run - Rundi;rus - Russian;sad - Sandawe;sag - Sango;sah - Yakut;sai - South American Indian (Other);sal - Salishan Languages;sam - Samaritan Aramaic;san - Sanskrit;sco - Scots;scr - Serbo-Croatian;sel - Selkup;sem - Semitic (Other);sga - Irish, Old (to 900);shn - Shan;sid - Sidamo;sin - Singhalese;sio - Siouan Languages;sit - Sino-Tibetan (Other);sla - Slavic (Other);slk - Slovak;slo - Slovak;slv - Slovenian;smi - Sami Languages;smo - Samoan;sna - Shona;snd - Sindhi;sog - Sogdian;som - Somali;son - Songhai;sot - Sotho, Southern;") + "spa - Spanish;sqi - Albanian;srd - Sardinian;srr - Serer;ssa - Nilo-Saharan (Other);ssw - Siswant;swz - Swazi;suk - Sukuma;sun - Sudanese;sus - Susu;sux - Sumerian;sve - Swedish;swa - Swahili;swe - Swedish;syr - Syriac;tah - Tahitian;tam - Tamil;tat - Tatar;tel - Telugu;tem - Timne;ter - Tereno;tgk - Tajik;tgl - Tagalog;tha - Thai;tib - Tibetan;tig - Tigre;tir - Tigrinya;tiv - Tivi;tli - Tlingit;tmh - Tamashek;tog - Tonga (Nyasa);ton - Tonga (Tonga Islands);tru - Truk;tsi - Tsimshian;tsn - Tswana;tso - Tsonga;tuk - Turkmen;tum - Tumbuka;tur - Turkish;tut - Altaic (Other);twi - Twi;tyv - Tuvinian;uga - Ugaritic;uig - Uighur;ukr - Ukrainian;umb - Umbundu;und - Undefined;urd - Urdu;uzb - Uzbek;vai - Vai;" + "ven - Venda;vie - Vietnamese;vol - Volapk;vot - Votic;wak - Wakashan Languages;wal - Walamo;war - Waray;was - Washo;wel - Welsh;wen - Sorbian Languages;wol - Wolof;xho - Xhosa;yao - Yao;yap - Yap;yid - Yiddish;yor - Yoruba;zap - Zapotec;zen - Zenaga;zha - Zhuang;zho - Chinese;zul - Zulu;zun - Zuni";
      string[] strArray = str.Split(new char[] { ',' });
      string[] strArray2 = str3.Split(new char[] { ',' });
      astrGenreLookup = str4.Split(new char[] { ',' });
      astrDefinedFrames = str2.Split(new char[] { ',' });
      astrLanLookup = str5.Split(new char[] { ';' });
      int num = 0;
      do
      {
        int num3 = 0;
        do
        {
          aintBitrateLookup[7 - num3, num] = Convert.ToInt32(strArray[(num * 6) + num3]);
          num3++;
        }
        while (num3 <= 2);
        num3 = 0;
        do
        {
          aintBitrateLookup[3 - num3, num] = Convert.ToInt32(strArray[((num * 6) + 3) + num3]);
          num3++;
        }
        while (num3 <= 2);
        num++;
      }
      while (num <= 15);
      int num2 = 0;
      do
      {
        aintFreqLookup[3, num2] = Convert.ToInt32(strArray2[num2 * 3]);
        aintFreqLookup[2, num2] = Convert.ToInt32(strArray2[(num2 * 3) + 1]);
        aintFreqLookup[0, num2] = Convert.ToInt32(strArray2[(num2 * 3) + 2]);
        num2++;
      }
      while (num2 <= 3);
      asinBaseLenLayer1[0] = 0.008707483f;
      asinBaseLenLayer1[1] = 0.008f;
      asinBaseLenLayer1[2] = 0.012f;
      asinBaseLenLayer1[3] = 0f;
      asinBaseLenLayer23[0] = 0.02612245f;
      asinBaseLenLayer23[1] = 0.024f;
      asinBaseLenLayer23[2] = 0.036f;
      asinBaseLenLayer23[3] = 0f;
    }

    [DllImport("user32", CharSet = CharSet.Auto, SetLastError = true)]
    public static extern int DestroyIcon(IntPtr hIcon);
    [DllImport("user32", EntryPoint = "SendMessageA", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
    public static extern int ListViewColumnOrder(int hwnd, int Msg, int wParam, ref int lParam);
    [DllImport("User32", CharSet = CharSet.Auto)]
    public static extern IntPtr SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
    [DllImport("User32", CharSet = CharSet.Auto)]
    public static extern IntPtr SendMessage(IntPtr hWnd, int msg, int wParam, ref LVCOLUMN lParam);
    [DllImport("shell32", EntryPoint = "ShellExecuteExA", CharSet = CharSet.Auto, SetLastError = true)]
    public static extern int ShellExecuteEx(ref SHELLEXECUTEINFO SEI);
    [DllImport("shell32.dll", EntryPoint = "SHFileOperationA", CharSet = CharSet.Auto, SetLastError = true)]
    public static extern int SHFileOperation(ref SHFILEOPSTRUCT lpFileOp);
    [DllImport("shell32", CharSet = CharSet.Auto, SetLastError = true)]
    public static extern int SHGetFileInfo([MarshalAs(UnmanagedType.VBByRefStr)] ref string pszPath, int dwFileAttributes, ref SHFILEINFO psfi, int cbFileInfo, SHGFI uFlags);

    [StructLayout(LayoutKind.Sequential)]
    public struct CopyTAG
    {
      public ID3_TagIT.V1TAG V1TAG;
      public ID3_TagIT.V2TAG V2TAG;
      public CopyTAG(ID3_TagIT.V1TAG vV1TAG, ID3_TagIT.V2TAG vV2TAG)
      {
        this = new Declarations.CopyTAG();
        this.V1TAG = vV1TAG;
        this.V2TAG = vV2TAG;
      }
    }

    public enum FormatReplace
    {
      CompareTAGFilename = 0x20,
      FilenameToTAG = 8,
      OrganizeFiles = 0x10,
      TAGToFilename = 4,
      TAGVer1 = 1,
      TAGVer2 = 2
    }

    public enum FormatReplaceFeedback
    {
      InvalidCharFormat = 4,
      InvalidFormat = 2,
      OK = 1
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto, Pack = 8)]
    public struct LVCOLUMN
    {
      public int mask;
      public int fmt;
      public int cx;
      public IntPtr pszText;
      public int cchTextMax;
      public int iSubItem;
      public int iImage;
      public int iOrder;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct SHELLEXECUTEINFO
    {
      public int cbSize;
      public int fMask;
      public int hwnd;
      public string lpVerb;
      public string lpFile;
      public string lpParameters;
      public string lpDirectory;
      public int nShow;
      public int hInstApp;
      public int lpIDList;
      public string lpClass;
      public int hkeyClass;
      public int dwHotKey;
      public int hIcon;
      public int hProcess;
    }

    public enum ShellOperation
    {
      CopyOp = 2,
      DeleteOp = 3,
      MoveOp = 1
    }

    public enum ShellOperationFlags
    {
      AllowUndo = 0x40,
      CollisionRename = 8,
      FilesOnly = 0x80,
      MultipleDest = 1,
      NoConfirm = 0x10,
      NoConfirmDir = 0x200,
      NoDialog = 4,
      SimpleProgress = 0x100
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct SHFILEINFO
    {
      public IntPtr hIcon;
      public int iIcon;
      public int dwAttributes;
      [MarshalAs(UnmanagedType.LPStr)]
      public string szDisplayName;
      [MarshalAs(UnmanagedType.LPStr)]
      public string szTypeName;
      public SHFILEINFO(bool B)
      {
        this = new Declarations.SHFILEINFO();
        this.hIcon = IntPtr.Zero;
        this.iIcon = 0;
        this.dwAttributes = 0;
        this.szDisplayName = null;
        this.szTypeName = null;
      }
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct SHFILEOPSTRUCT
    {
      public int hWnd;
      public int wFunc;
      public string pFrom;
      public string pTo;
      public short fFlags;
      public bool fAborted;
      public int hNameMaps;
      public string sProgress;
    }

    [Flags]
    public enum SHGFI
    {
      ADDOVERLAYS = 0x20,
      ATTR_SPECIFIED = 0x20000,
      ATTRIBUTES = 0x800,
      DISPLAYNAME = 0x200,
      EXETYPE = 0x2000,
      ICON = 0x100,
      ICONLOCATION = 0x1000,
      LARGEICON = 0,
      LINKOVERLAY = 0x8000,
      OPENICON = 2,
      OVERLAYINDEX = 0x40,
      PIDL = 8,
      SELECTED = 0x10000,
      SHELLICONSIZE = 4,
      SMALLICON = 1,
      SYSICONINDEX = 0x4000,
      TYPENAME = 0x400,
      USEFILEATTRIBUTES = 0x10
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct UnDoReDo
    {
      public ID3_TagIT.MP3 MP3;
      public ID3_TagIT.V1TAG V1TAG;
      public ID3_TagIT.V2TAG V2TAG;
      public string Filename;
      public bool Changed;
      public UnDoReDo(ID3_TagIT.MP3 vMP3, ID3_TagIT.V1TAG vV1TAG, ID3_TagIT.V2TAG vV2TAG, string vFilename, bool vChanged)
      {
        this = new Declarations.UnDoReDo();
        this.MP3 = vMP3;
        this.V1TAG = vV1TAG;
        this.V2TAG = vV2TAG;
        this.Filename = vFilename;
        this.Changed = vChanged;
      }
    }
  }
}