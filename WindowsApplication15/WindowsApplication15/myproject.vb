<?xml version="1.0" encoding="utf-8"?>
<Project ToolsVersion="4.0" DefaultTargets="Build" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">x86</Platform>
    <ProductVersion>
    </ProductVersion>
    <SchemaVersion>2.0</SchemaVersion>
    <ProjectGuid>{91CA73B0-AD0A-4DB5-BDA4-37D61E4B96D4}</ProjectGuid>
    <OutputType>WinExe</OutputType>
    <StartupObject>WindowsApplication15.My.MyApplication</StartupObject>
    <RootNamespace>WindowsApplication15</RootNamespace>
    <AssemblyName>WindowsApplication15</AssemblyName>
    <FileAlignment>512</FileAlignment>
    <MyType>WindowsForms</MyType>
    <TargetFrameworkVersion>v4.0</TargetFrameworkVersion>
    <TargetFrameworkProfile>Client</TargetFrameworkProfile>
    <PublishUrl>publish\</PublishUrl>
    <Install>true</Install>
    <InstallFrom>Disk</InstallFrom>
    <UpdateEnabled>false</UpdateEnabled>
    <UpdateMode>Foreground</UpdateMode>
    <UpdateInterval>7</UpdateInterval>
    <UpdateIntervalUnits>Days</UpdateIntervalUnits>
    <UpdatePeriodically>false</UpdatePeriodically>
    <UpdateRequired>false</UpdateRequired>
    <MapFileExtensions>true</MapFileExtensions>
    <ApplicationRevision>0</ApplicationRevision>
    <ApplicationVersion>1.0.0.%2a</ApplicationVersion>
    <IsWebBootstrapper>false</IsWebBootstrapper>
    <UseApplicationTrust>false</UseApplicationTrust>
    <BootstrapperEnabled>true</BootstrapperEnabled>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Debug|x86' ">
    <PlatformTarget>x86</PlatformTarget>
    <DebugSymbols>true</DebugSymbols>
    <DebugType>full</DebugType>
    <DefineDebug>true</DefineDebug>
    <DefineTrace>true</DefineTrace>
    <OutputPath>bin\Debug\</OutputPath>
    <DocumentationFile>WindowsApplication15.xml</DocumentationFile>
    <NoWarn>42016,41999,42017,42018,42019,42032,42036,42020,42021,42022</NoWarn>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Release|x86' ">
    <PlatformTarget>x86</PlatformTarget>
    <DebugType>pdbonly</DebugType>
    <DefineDebug>false</DefineDebug>
    <DefineTrace>true</DefineTrace>
    <Optimize>true</Optimize>
    <OutputPath>bin\Release\</OutputPath>
    <DocumentationFile>WindowsApplication15.xml</DocumentationFile>
    <NoWarn>42016,41999,42017,42018,42019,42032,42036,42020,42021,42022</NoWarn>
  </PropertyGroup>
  <PropertyGroup>
    <OptionExplicit>On</OptionExplicit>
  </PropertyGroup>
  <PropertyGroup>
    <OptionCompare>Binary</OptionCompare>
  </PropertyGroup>
  <PropertyGroup>
    <OptionStrict>Off</OptionStrict>
  </PropertyGroup>
  <PropertyGroup>
    <OptionInfer>On</OptionInfer>
  </PropertyGroup>
  <ItemGroup>
    <Reference Include="Microsoft.VisualBasic.PowerPacks.Vs, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a, processorArchitecture=MSIL" />
    <Reference Include="System" />
    <Reference Include="System.Data" />
    <Reference Include="System.Deployment" />
    <Reference Include="System.Drawing" />
    <Reference Include="System.Windows.Forms" />
    <Reference Include="System.Xml" />
    <Reference Include="System.Core" />
    <Reference Include="System.Xml.Linq" />
    <Reference Include="System.Data.DataSetExtensions" />
  </ItemGroup>
  <ItemGroup>
    <Import Include="Microsoft.VisualBasic" />
    <Import Include="System" />
    <Import Include="System.Collections" />
    <Import Include="System.Collections.Generic" />
    <Import Include="System.Data" />
    <Import Include="System.Drawing" />
    <Import Include="System.Diagnostics" />
    <Import Include="System.Windows.Forms" />
    <Import Include="System.Linq" />
    <Import Include="System.Xml.Linq" />
  </ItemGroup>
  <ItemGroup>
    <Compile Include="agervati.Designer.vb">
      <DependentUpon>agervati.vb</DependentUpon>
    </Compile>
    <Compile Include="agervati.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="anu.Designer.vb">
      <DependentUpon>anu.vb</DependentUpon>
    </Compile>
    <Compile Include="anu.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="arishta.Designer.vb">
      <DependentUpon>arishta.vb</DependentUpon>
    </Compile>
    <Compile Include="arishta.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="asva.Designer.vb">
      <DependentUpon>asva.vb</DependentUpon>
    </Compile>
    <Compile Include="asva.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="bam.Designer.vb">
      <DependentUpon>bam.vb</DependentUpon>
    </Compile>
    <Compile Include="bam.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="Bdaampista.Designer.vb">
      <DependentUpon>Bdaampista.vb</DependentUpon>
    </Compile>
    <Compile Include="Bdaampista.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="bdam.Designer.vb">
      <DependentUpon>bdam.vb</DependentUpon>
    </Compile>
    <Compile Include="bdam.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="bes.Designer.vb">
      <DependentUpon>bes.vb</DependentUpon>
    </Compile>
    <Compile Include="bes.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="bodycare.Designer.vb">
      <DependentUpon>bodycare.vb</DependentUpon>
    </Compile>
    <Compile Include="bodycare.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="BROKEN.Designer.vb">
      <DependentUpon>BROKEN.vb</DependentUpon>
    </Compile>
    <Compile Include="BROKEN.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="BURA.Designer.vb">
      <DependentUpon>BURA.vb</DependentUpon>
    </Compile>
    <Compile Include="BURA.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="candy.Designer.vb">
      <DependentUpon>candy.vb</DependentUpon>
    </Compile>
    <Compile Include="candy.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="CF.Designer.vb">
      <DependentUpon>CF.vb</DependentUpon>
    </Compile>
    <Compile Include="CF.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="chikki.Designer.vb">
      <DependentUpon>chikki.vb</DependentUpon>
    </Compile>
    <Compile Include="chikki.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="childcare.Designer.vb">
      <DependentUpon>childcare.vb</DependentUpon>
    </Compile>
    <Compile Include="childcare.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="chips.Designer.vb">
      <DependentUpon>chips.vb</DependentUpon>
    </Compile>
    <Compile Include="chips.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="chy.Designer.vb">
      <DependentUpon>chy.vb</DependentUpon>
    </Compile>
    <Compile Include="chy.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="cold.Designer.vb">
      <DependentUpon>cold.vb</DependentUpon>
    </Compile>
    <Compile Include="cold.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="condi.Designer.vb">
      <DependentUpon>condi.vb</DependentUpon>
    </Compile>
    <Compile Include="condi.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="cream.Designer.vb">
      <DependentUpon>cream.vb</DependentUpon>
    </Compile>
    <Compile Include="cream.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="detergentcake.Designer.vb">
      <DependentUpon>detergentcake.vb</DependentUpon>
    </Compile>
    <Compile Include="detergentcake.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="detergentpowder.Designer.vb">
      <DependentUpon>detergentpowder.vb</DependentUpon>
    </Compile>
    <Compile Include="detergentpowder.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="dhoop.Designer.vb">
      <DependentUpon>dhoop.vb</DependentUpon>
    </Compile>
    <Compile Include="dhoop.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="diet.Designer.vb">
      <DependentUpon>diet.vb</DependentUpon>
    </Compile>
    <Compile Include="diet.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="dig.Designer.vb">
      <DependentUpon>dig.vb</DependentUpon>
    </Compile>
    <Compile Include="dig.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="dishwash.Designer.vb">
      <DependentUpon>dishwash.vb</DependentUpon>
    </Compile>
    <Compile Include="dishwash.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="eye.Designer.vb">
      <DependentUpon>eye.vb</DependentUpon>
    </Compile>
    <Compile Include="eye.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="facepack.Designer.vb">
      <DependentUpon>facepack.vb</DependentUpon>
    </Compile>
    <Compile Include="facepack.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="Facescrub.Designer.vb">
      <DependentUpon>Facescrub.vb</DependentUpon>
    </Compile>
    <Compile Include="Facescrub.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="fashwash.Designer.vb">
      <DependentUpon>fashwash.vb</DependentUpon>
    </Compile>
    <Compile Include="fashwash.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="fj.Designer.vb">
      <DependentUpon>fj.vb</DependentUpon>
    </Compile>
    <Compile Include="fj.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="bhsma.Designer.vb">
      <DependentUpon>bhsma.vb</DependentUpon>
    </Compile>
    <Compile Include="bhsma.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="Footcream.Designer.vb">
      <DependentUpon>Footcream.vb</DependentUpon>
    </Compile>
    <Compile Include="Footcream.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="gajak.Designer.vb">
      <DependentUpon>gajak.vb</DependentUpon>
    </Compile>
    <Compile Include="gajak.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="ghi.Designer.vb">
      <DependentUpon>ghi.vb</DependentUpon>
    </Compile>
    <Compile Include="ghi.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="godhrk.Designer.vb">
      <DependentUpon>godhrk.vb</DependentUpon>
    </Compile>
    <Compile Include="godhrk.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="gram.Designer.vb">
      <DependentUpon>gram.vb</DependentUpon>
    </Compile>
    <Compile Include="gram.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="GUGUL.Designer.vb">
      <DependentUpon>GUGUL.vb</DependentUpon>
    </Compile>
    <Compile Include="GUGUL.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="gulcose.Designer.vb">
      <DependentUpon>gulcose.vb</DependentUpon>
    </Compile>
    <Compile Include="gulcose.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="hand.Designer.vb">
      <DependentUpon>hand.vb</DependentUpon>
    </Compile>
    <Compile Include="hand.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="hawan.Designer.vb">
      <DependentUpon>hawan.vb</DependentUpon>
    </Compile>
    <Compile Include="hawan.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="hd.Designer.vb">
      <DependentUpon>hd.vb</DependentUpon>
    </Compile>
    <Compile Include="hd.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="herbalTea.Designer.vb">
      <DependentUpon>herbalTea.vb</DependentUpon>
    </Compile>
    <Compile Include="herbalTea.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="hm.Designer.vb">
      <DependentUpon>hm.vb</DependentUpon>
    </Compile>
    <Compile Include="hm.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="hon.Designer.vb">
      <DependentUpon>hon.vb</DependentUpon>
    </Compile>
    <Compile Include="hon.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="hw.Designer.vb">
      <DependentUpon>hw.vb</DependentUpon>
    </Compile>
    <Compile Include="hw.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="jal.Designer.vb">
      <DependentUpon>jal.vb</DependentUpon>
    </Compile>
    <Compile Include="jal.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="jm.Designer.vb">
      <DependentUpon>jm.vb</DependentUpon>
    </Compile>
    <Compile Include="jm.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="katchup.Designer.vb">
      <DependentUpon>katchup.vb</DependentUpon>
    </Compile>
    <Compile Include="katchup.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="katori.Designer.vb">
      <DependentUpon>katori.vb</DependentUpon>
    </Compile>
    <Compile Include="katori.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="kwath.Designer.vb">
      <DependentUpon>kwath.vb</DependentUpon>
    </Compile>
    <Compile Include="kwath.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="lotion.Designer.vb">
      <DependentUpon>lotion.vb</DependentUpon>
    </Compile>
    <Compile Include="lotion.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="lt.Designer.vb">
      <DependentUpon>lt.vb</DependentUpon>
    </Compile>
    <Compile Include="lt.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="M0IL.Designer.vb">
      <DependentUpon>M0IL.vb</DependentUpon>
    </Compile>
    <Compile Include="M0IL.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="medic.Designer.vb">
      <DependentUpon>medic.vb</DependentUpon>
    </Compile>
    <Compile Include="medic.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="murrabA.Designer.vb">
      <DependentUpon>murrabA.vb</DependentUpon>
    </Compile>
    <Compile Include="murrabA.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="My Project\Resources.Designer.vb">
      <AutoGen>True</AutoGen>
      <DesignTime>True</DesignTime>
      <DependentUpon>Resources.resx</DependentUpon>
    </Compile>
    <Compile Include="NOODLES.Designer.VB">
      <DependentUpon>NOODLES.VB</DependentUpon>
    </Compile>
    <Compile Include="NOODLES.VB">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="Oatsvb.Designer.vb">
      <DependentUpon>Oatsvb.vb</DependentUpon>
    </Compile>
    <Compile Include="Oatsvb.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="oil.Designer.vb">
      <DependentUpon>oil.vb</DependentUpon>
    </Compile>
    <Compile Include="oil.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="papad.Designer.vb">
      <DependentUpon>papad.vb</DependentUpon>
    </Compile>
    <Compile Include="papad.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="parpati.Designer.vb">
      <DependentUpon>parpati.vb</DependentUpon>
    </Compile>
    <Compile Include="parpati.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="patanjalchuran.Designer.vb">
      <DependentUpon>patanjalchuran.vb</DependentUpon>
    </Compile>
    <Compile Include="patanjalchuran.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="patanjaliDataSet.Designer.vb">
      <AutoGen>True</AutoGen>
      <DesignTime>True</DesignTime>
      <DependentUpon>patanjaliDataSet.xsd</DependentUpon>
    </Compile>
    <Compile Include="patanjaliDataSet1.Designer.vb">
      <AutoGen>True</AutoGen>
      <DesignTime>True</DesignTime>
      <DependentUpon>patanjaliDataSet1.xsd</DependentUpon>
    </Compile>
    <Compile Include="patanjaliDataSet10.Designer.vb">
      <AutoGen>True</AutoGen>
      <DesignTime>True</DesignTime>
      <DependentUpon>patanjaliDataSet10.xsd</DependentUpon>
    </Compile>
    <Compile Include="patanjaliDataSet11.Designer.vb">
      <AutoGen>True</AutoGen>
      <DesignTime>True</DesignTime>
      <DependentUpon>patanjaliDataSet11.xsd</DependentUpon>
    </Compile>
    <Compile Include="patanjaliDataSet12.Designer.vb">
      <AutoGen>True</AutoGen>
      <DesignTime>True</DesignTime>
      <DependentUpon>patanjaliDataSet12.xsd</DependentUpon>
    </Compile>
    <Compile Include="patanjaliDataSet13.Designer.vb">
      <AutoGen>True</AutoGen>
      <DesignTime>True</DesignTime>
      <DependentUpon>patanjaliDataSet13.xsd</DependentUpon>
    </Compile>
    <Compile Include="patanjaliDataSet14.Designer.vb">
      <AutoGen>True</AutoGen>
      <DesignTime>True</DesignTime>
      <DependentUpon>patanjaliDataSet14.xsd</DependentUpon>
    </Compile>
    <Compile Include="patanjaliDataSet15.Designer.vb">
      <AutoGen>True</AutoGen>
      <DesignTime>True</DesignTime>
      <DependentUpon>patanjaliDataSet15.xsd</DependentUpon>
    </Compile>
    <Compile Include="patanjaliDataSet16.Designer.vb">
      <AutoGen>True</AutoGen>
      <DesignTime>True</DesignTime>
      <DependentUpon>patanjaliDataSet16.xsd</DependentUpon>
    </Compile>
    <Compile Include="patanjaliDataSet17.Designer.vb">
      <AutoGen>True</AutoGen>
      <DesignTime>True</DesignTime>
      <DependentUpon>patanjaliDataSet17.xsd</DependentUpon>
    </Compile>
    <Compile Include="patanjaliDataSet18.Designer.vb">
      <AutoGen>True</AutoGen>
      <DesignTime>True</DesignTime>
      <DependentUpon>patanjaliDataSet18.xsd</DependentUpon>
    </Compile>
    <Compile Include="patanjaliDataSet19.Designer.vb">
      <AutoGen>True</AutoGen>
      <DesignTime>True</DesignTime>
      <DependentUpon>patanjaliDataSet19.xsd</DependentUpon>
    </Compile>
    <Compile Include="patanjaliDataSet2.Designer.vb">
      <AutoGen>True</AutoGen>
      <DesignTime>True</DesignTime>
      <DependentUpon>patanjaliDataSet2.xsd</DependentUpon>
    </Compile>
    <Compile Include="patanjaliDataSet20.Designer.vb">
      <AutoGen>True</AutoGen>
      <DesignTime>True</DesignTime>
      <DependentUpon>patanjaliDataSet20.xsd</DependentUpon>
    </Compile>
    <Compile Include="patanjaliDataSet21.Designer.vb">
      <AutoGen>True</AutoGen>
      <DesignTime>True</DesignTime>
      <DependentUpon>patanjaliDataSet21.xsd</DependentUpon>
    </Compile>
    <Compile Include="patanjaliDataSet22.Designer.vb">
      <AutoGen>True</AutoGen>
      <DesignTime>True</DesignTime>
      <DependentUpon>patanjaliDataSet22.xsd</DependentUpon>
    </Compile>
    <Compile Include="patanjaliDataSet23.Designer.vb">
      <AutoGen>True</AutoGen>
      <DesignTime>True</DesignTime>
      <DependentUpon>patanjaliDataSet23.xsd</DependentUpon>
    </Compile>
    <Compile Include="patanjaliDataSet24.Designer.vb">
      <AutoGen>True</AutoGen>
      <DesignTime>True</DesignTime>
      <DependentUpon>patanjaliDataSet24.xsd</DependentUpon>
    </Compile>
    <Compile Include="patanjaliDataSet25.Designer.vb">
      <AutoGen>True</AutoGen>
      <DesignTime>True</DesignTime>
      <DependentUpon>patanjaliDataSet25.xsd</DependentUpon>
    </Compile>
    <Compile Include="patanjaliDataSet26.Designer.vb">
      <AutoGen>True</AutoGen>
      <DesignTime>True</DesignTime>
      <DependentUpon>patanjaliDataSet26.xsd</DependentUpon>
    </Compile>
    <Compile Include="patanjaliDataSet27.Designer.vb">
      <AutoGen>True</AutoGen>
      <DesignTime>True</DesignTime>
      <DependentUpon>patanjaliDataSet27.xsd</DependentUpon>
    </Compile>
    <Compile Include="patanjaliDataSet28.Designer.vb">
      <AutoGen>True</AutoGen>
      <DesignTime>True</DesignTime>
      <DependentUpon>patanjaliDataSet28.xsd</DependentUpon>
    </Compile>
    <Compile Include="patanjaliDataSet29.Designer.vb">
      <AutoGen>True</AutoGen>
      <DesignTime>True</DesignTime>
      <DependentUpon>patanjaliDataSet29.xsd</DependentUpon>
    </Compile>
    <Compile Include="patanjaliDataSet3.Designer.vb">
      <AutoGen>True</AutoGen>
      <DesignTime>True</DesignTime>
      <DependentUpon>patanjaliDataSet3.xsd</DependentUpon>
    </Compile>
    <Compile Include="patanjaliDataSet30.Designer.vb">
      <AutoGen>True</AutoGen>
      <DesignTime>True</DesignTime>
      <DependentUpon>patanjaliDataSet30.xsd</DependentUpon>
    </Compile>
    <Compile Include="patanjaliDataSet31.Designer.vb">
      <AutoGen>True</AutoGen>
      <DesignTime>True</DesignTime>
      <DependentUpon>patanjaliDataSet31.xsd</DependentUpon>
    </Compile>
    <Compile Include="patanjaliDataSet32.Designer.vb">
      <AutoGen>True</AutoGen>
      <DesignTime>True</DesignTime>
      <DependentUpon>patanjaliDataSet32.xsd</DependentUpon>
    </Compile>
    <Compile Include="patanjaliDataSet33.Designer.vb">
      <AutoGen>True</AutoGen>
      <DesignTime>True</DesignTime>
      <DependentUpon>patanjaliDataSet33.xsd</DependentUpon>
    </Compile>
    <Compile Include="patanjaliDataSet34.Designer.vb">
      <AutoGen>True</AutoGen>
      <DesignTime>True</DesignTime>
      <DependentUpon>patanjaliDataSet34.xsd</DependentUpon>
    </Compile>
    <Compile Include="patanjaliDataSet35.Designer.vb">
      <AutoGen>True</AutoGen>
      <DesignTime>True</DesignTime>
      <DependentUpon>patanjaliDataSet35.xsd</DependentUpon>
    </Compile>
    <Compile Include="patanjaliDataSet36.Designer.vb">
      <AutoGen>True</AutoGen>
      <DesignTime>True</DesignTime>
      <DependentUpon>patanjaliDataSet36.xsd</DependentUpon>
    </Compile>
    <Compile Include="patanjaliDataSet37.Designer.vb">
      <AutoGen>True</AutoGen>
      <DesignTime>True</DesignTime>
      <DependentUpon>patanjaliDataSet37.xsd</DependentUpon>
    </Compile>
    <Compile Include="patanjaliDataSet38.Designer.vb">
      <AutoGen>True</AutoGen>
      <DesignTime>True</DesignTime>
      <DependentUpon>patanjaliDataSet38.xsd</DependentUpon>
    </Compile>
    <Compile Include="patanjaliDataSet39.Designer.vb">
      <AutoGen>True</AutoGen>
      <DesignTime>True</DesignTime>
      <DependentUpon>patanjaliDataSet39.xsd</DependentUpon>
    </Compile>
    <Compile Include="patanjaliDataSet4.Designer.vb">
      <AutoGen>True</AutoGen>
      <DesignTime>True</DesignTime>
      <DependentUpon>patanjaliDataSet4.xsd</DependentUpon>
    </Compile>
    <Compile Include="patanjaliDataSet40.Designer.vb">
      <AutoGen>True</AutoGen>
      <DesignTime>True</DesignTime>
      <DependentUpon>patanjaliDataSet40.xsd</DependentUpon>
    </Compile>
    <Compile Include="patanjaliDataSet41.Designer.vb">
      <AutoGen>True</AutoGen>
      <DesignTime>True</DesignTime>
      <DependentUpon>patanjaliDataSet41.xsd</DependentUpon>
    </Compile>
    <Compile Include="patanjaliDataSet42.Designer.vb">
      <AutoGen>True</AutoGen>
      <DesignTime>True</DesignTime>
      <DependentUpon>patanjaliDataSet42.xsd</DependentUpon>
    </Compile>
    <Compile Include="patanjaliDataSet43.Designer.vb">
      <AutoGen>True</AutoGen>
      <DesignTime>True</DesignTime>
      <DependentUpon>patanjaliDataSet43.xsd</DependentUpon>
    </Compile>
    <Compile Include="patanjaliDataSet44.Designer.vb">
      <AutoGen>True</AutoGen>
      <DesignTime>True</DesignTime>
      <DependentUpon>patanjaliDataSet44.xsd</DependentUpon>
    </Compile>
    <Compile Include="patanjaliDataSet45.Designer.vb">
      <AutoGen>True</AutoGen>
      <DesignTime>True</DesignTime>
      <DependentUpon>patanjaliDataSet45.xsd</DependentUpon>
    </Compile>
    <Compile Include="patanjaliDataSet46.Designer.vb">
      <AutoGen>True</AutoGen>
      <DesignTime>True</DesignTime>
      <DependentUpon>patanjaliDataSet46.xsd</DependentUpon>
    </Compile>
    <Compile Include="patanjaliDataSet47.Designer.vb">
      <AutoGen>True</AutoGen>
      <DesignTime>True</DesignTime>
      <DependentUpon>patanjaliDataSet47.xsd</DependentUpon>
    </Compile>
    <Compile Include="patanjaliDataSet48.Designer.vb">
      <AutoGen>True</AutoGen>
      <DesignTime>True</DesignTime>
      <DependentUpon>patanjaliDataSet48.xsd</DependentUpon>
    </Compile>
    <Compile Include="patanjaliDataSet49.Designer.vb">
      <AutoGen>True</AutoGen>
      <DesignTime>True</DesignTime>
      <DependentUpon>patanjaliDataSet49.xsd</DependentUpon>
    </Compile>
    <Compile Include="patanjaliDataSet5.Designer.vb">
      <AutoGen>True</AutoGen>
      <DesignTime>True</DesignTime>
      <DependentUpon>patanjaliDataSet5.xsd</DependentUpon>
    </Compile>
    <Compile Include="patanjaliDataSet50.Designer.vb">
      <AutoGen>True</AutoGen>
      <DesignTime>True</DesignTime>
      <DependentUpon>patanjaliDataSet50.xsd</DependentUpon>
    </Compile>
    <Compile Include="patanjaliDataSet51.Designer.vb">
      <AutoGen>True</AutoGen>
      <DesignTime>True</DesignTime>
      <DependentUpon>patanjaliDataSet51.xsd</DependentUpon>
    </Compile>
    <Compile Include="patanjaliDataSet52.Designer.vb">
      <AutoGen>True</AutoGen>
      <DesignTime>True</DesignTime>
      <DependentUpon>patanjaliDataSet52.xsd</DependentUpon>
    </Compile>
    <Compile Include="patanjaliDataSet53.Designer.vb">
      <AutoGen>True</AutoGen>
      <DesignTime>True</DesignTime>
      <DependentUpon>patanjaliDataSet53.xsd</DependentUpon>
    </Compile>
    <Compile Include="patanjaliDataSet54.Designer.vb">
      <AutoGen>True</AutoGen>
      <DesignTime>True</DesignTime>
      <DependentUpon>patanjaliDataSet54.xsd</DependentUpon>
    </Compile>
    <Compile Include="patanjaliDataSet55.Designer.vb">
      <AutoGen>True</AutoGen>
      <DesignTime>True</DesignTime>
      <DependentUpon>patanjaliDataSet55.xsd</DependentUpon>
    </Compile>
    <Compile Include="patanjaliDataSet56.Designer.vb">
      <AutoGen>True</AutoGen>
      <DesignTime>True</DesignTime>
      <DependentUpon>patanjaliDataSet56.xsd</DependentUpon>
    </Compile>
    <Compile Include="patanjaliDataSet57.Designer.vb">
      <AutoGen>True</AutoGen>
      <DesignTime>True</DesignTime>
      <DependentUpon>patanjaliDataSet57.xsd</DependentUpon>
    </Compile>
    <Compile Include="patanjaliDataSet58.Designer.vb">
      <AutoGen>True</AutoGen>
      <DesignTime>True</DesignTime>
      <DependentUpon>patanjaliDataSet58.xsd</DependentUpon>
    </Compile>
    <Compile Include="patanjaliDataSet59.Designer.vb">
      <AutoGen>True</AutoGen>
      <DesignTime>True</DesignTime>
      <DependentUpon>patanjaliDataSet59.xsd</DependentUpon>
    </Compile>
    <Compile Include="patanjaliDataSet6.Designer.vb">
      <AutoGen>True</AutoGen>
      <DesignTime>True</DesignTime>
      <DependentUpon>patanjaliDataSet6.xsd</DependentUpon>
    </Compile>
    <Compile Include="patanjaliDataSet60.Designer.vb">
      <AutoGen>True</AutoGen>
      <DesignTime>True</DesignTime>
      <DependentUpon>patanjaliDataSet60.xsd</DependentUpon>
    </Compile>
    <Compile Include="patanjaliDataSet61.Designer.vb">
      <AutoGen>True</AutoGen>
      <DesignTime>True</DesignTime>
      <DependentUpon>patanjaliDataSet61.xsd</DependentUpon>
    </Compile>
    <Compile Include="patanjaliDataSet62.Designer.vb">
      <AutoGen>True</AutoGen>
      <DesignTime>True</DesignTime>
      <DependentUpon>patanjaliDataSet62.xsd</DependentUpon>
    </Compile>
    <Compile Include="patanjaliDataSet63.Designer.vb">
      <AutoGen>True</AutoGen>
      <DesignTime>True</DesignTime>
      <DependentUpon>patanjaliDataSet63.xsd</DependentUpon>
    </Compile>
    <Compile Include="patanjaliDataSet64.Designer.vb">
      <AutoGen>True</AutoGen>
      <DesignTime>True</DesignTime>
      <DependentUpon>patanjaliDataSet64.xsd</DependentUpon>
    </Compile>
    <Compile Include="patanjaliDataSet65.Designer.vb">
      <AutoGen>True</AutoGen>
      <DesignTime>True</DesignTime>
      <DependentUpon>patanjaliDataSet65.xsd</DependentUpon>
    </Compile>
    <Compile Include="patanjaliDataSet66.Designer.vb">
      <AutoGen>True</AutoGen>
      <DesignTime>True</DesignTime>
      <DependentUpon>patanjaliDataSet66.xsd</DependentUpon>
    </Compile>
    <Compile Include="patanjaliDataSet67.Designer.vb">
      <AutoGen>True</AutoGen>
      <DesignTime>True</DesignTime>
      <DependentUpon>patanjaliDataSet67.xsd</DependentUpon>
    </Compile>
    <Compile Include="patanjaliDataSet68.Designer.vb">
      <AutoGen>True</AutoGen>
      <DesignTime>True</DesignTime>
      <DependentUpon>patanjaliDataSet68.xsd</DependentUpon>
    </Compile>
    <Compile Include="patanjaliDataSet69.Designer.vb">
      <AutoGen>True</AutoGen>
      <DesignTime>True</DesignTime>
      <DependentUpon>patanjaliDataSet69.xsd</DependentUpon>
    </Compile>
    <Compile Include="patanjaliDataSet7.Designer.vb">
      <AutoGen>True</AutoGen>
      <DesignTime>True</DesignTime>
      <DependentUpon>patanjaliDataSet7.xsd</DependentUpon>
    </Compile>
    <Compile Include="patanjaliDataSet70.Designer.vb">
      <AutoGen>True</AutoGen>
      <DesignTime>True</DesignTime>
      <DependentUpon>patanjaliDataSet70.xsd</DependentUpon>
    </Compile>
    <Compile Include="patanjaliDataSet71.Designer.vb">
      <AutoGen>True</AutoGen>
      <DesignTime>True</DesignTime>
      <DependentUpon>patanjaliDataSet71.xsd</DependentUpon>
    </Compile>
    <Compile Include="patanjaliDataSet72.Designer.vb">
      <AutoGen>True</AutoGen>
      <DesignTime>True</DesignTime>
      <DependentUpon>patanjaliDataSet72.xsd</DependentUpon>
    </Compile>
    <Compile Include="patanjaliDataSet73.Designer.vb">
      <AutoGen>True</AutoGen>
      <DesignTime>True</DesignTime>
      <DependentUpon>patanjaliDataSet73.xsd</DependentUpon>
    </Compile>
    <Compile Include="patanjaliDataSet74.Designer.vb">
      <AutoGen>True</AutoGen>
      <DesignTime>True</DesignTime>
      <DependentUpon>patanjaliDataSet74.xsd</DependentUpon>
    </Compile>
    <Compile Include="patanjaliDataSet75.Designer.vb">
      <AutoGen>True</AutoGen>
      <DesignTime>True</DesignTime>
      <DependentUpon>patanjaliDataSet75.xsd</DependentUpon>
    </Compile>
    <Compile Include="patanjaliDataSet76.Designer.vb">
      <AutoGen>True</AutoGen>
      <DesignTime>True</DesignTime>
      <DependentUpon>patanjaliDataSet76.xsd</DependentUpon>
    </Compile>
    <Compile Include="patanjaliDataSet77.Designer.vb">
      <AutoGen>True</AutoGen>
      <DesignTime>True</DesignTime>
      <DependentUpon>patanjaliDataSet77.xsd</DependentUpon>
    </Compile>
    <Compile Include="patanjaliDataSet78.Designer.vb">
      <AutoGen>True</AutoGen>
      <DesignTime>True</DesignTime>
      <DependentUpon>patanjaliDataSet78.xsd</DependentUpon>
    </Compile>
    <Compile Include="patanjaliDataSet79.Designer.vb">
      <AutoGen>True</AutoGen>
      <DesignTime>True</DesignTime>
      <DependentUpon>patanjaliDataSet79.xsd</DependentUpon>
    </Compile>
    <Compile Include="patanjaliDataSet8.Designer.vb">
      <AutoGen>True</AutoGen>
      <DesignTime>True</DesignTime>
      <DependentUpon>patanjaliDataSet8.xsd</DependentUpon>
    </Compile>
    <Compile Include="patanjaliDataSet80.Designer.vb">
      <AutoGen>True</AutoGen>
      <DesignTime>True</DesignTime>
      <DependentUpon>patanjaliDataSet80.xsd</DependentUpon>
    </Compile>
    <Compile Include="patanjaliDataSet81.Designer.vb">
      <AutoGen>True</AutoGen>
      <DesignTime>True</DesignTime>
      <DependentUpon>patanjaliDataSet81.xsd</DependentUpon>
    </Compile>
    <Compile Include="patanjaliDataSet82.Designer.vb">
      <AutoGen>True</AutoGen>
      <DesignTime>True</DesignTime>
      <DependentUpon>patanjaliDataSet82.xsd</DependentUpon>
    </Compile>
    <Compile Include="patanjaliDataSet83.Designer.vb">
      <AutoGen>True</AutoGen>
      <DesignTime>True</DesignTime>
      <DependentUpon>patanjaliDataSet83.xsd</DependentUpon>
    </Compile>
    <Compile Include="patanjaliDataSet84.Designer.vb">
      <AutoGen>True</AutoGen>
      <DesignTime>True</DesignTime>
      <DependentUpon>patanjaliDataSet84.xsd</DependentUpon>
    </Compile>
    <Compile Include="patanjaliDataSet9.Designer.vb">
      <AutoGen>True</AutoGen>
      <DesignTime>True</DesignTime>
      <DependentUpon>patanjaliDataSet9.xsd</DependentUpon>
    </Compile>
    <Compile Include="patanjlioil.Designer.vb">
      <DependentUpon>patanjlioil.vb</DependentUpon>
    </Compile>
    <Compile Include="patanjlioil.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="pers.Designer.vb">
      <DependentUpon>pers.vb</DependentUpon>
    </Compile>
    <Compile Include="pers.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="groc.Designer.vb">
      <DependentUpon>groc.vb</DependentUpon>
    </Compile>
    <Compile Include="groc.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="h.Designer.vb">
      <DependentUpon>h.vb</DependentUpon>
    </Compile>
    <Compile Include="h.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="mainpage.Designer.vb">
      <DependentUpon>mainpage.vb</DependentUpon>
    </Compile>
    <Compile Include="mainpage.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="login.Designer.vb">
      <DependentUpon>login.vb</DependentUpon>
    </Compile>
    <Compile Include="login.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="My Project\AssemblyInfo.vb" />
    <Compile Include="My Project\Application.Designer.vb">
      <AutoGen>True</AutoGen>
      <DependentUpon>Application.myapp</DependentUpon>
    </Compile>
    <Compile Include="My Project\Settings.Designer.vb">
      <AutoGen>True</AutoGen>
      <DependentUpon>Settings.settings</DependentUpon>
      <DesignTimeSharedInput>True</DesignTimeSharedInput>
    </Compile>
    <Compile Include="pic.Designer.vb">
      <DependentUpon>pic.vb</DependentUpon>
    </Compile>
    <Compile Include="pic.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="pishti.Designer.vb">
      <DependentUpon>pishti.vb</DependentUpon>
    </Compile>
    <Compile Include="pishti.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="PULSES.Designer.VB">
      <DependentUpon>PULSES.VB</DependentUpon>
    </Compile>
    <Compile Include="PULSES.VB">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="reg.Designer.vb">
      <DependentUpon>reg.vb</DependentUpon>
    </Compile>
    <Compile Include="reg.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="Rewari.Designer.vb">
      <DependentUpon>Rewari.vb</DependentUpon>
    </Compile>
    <Compile Include="Rewari.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="RICE.Designer.VB">
      <DependentUpon>RICE.VB</DependentUpon>
    </Compile>
    <Compile Include="RICE.VB">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="shampoo.Designer.vb">
      <DependentUpon>shampoo.vb</DependentUpon>
    </Compile>
    <Compile Include="shampoo.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="shaving.Designer.vb">
      <DependentUpon>shaving.vb</DependentUpon>
    </Compile>
    <Compile Include="shaving.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="skincare.Designer.vb">
      <DependentUpon>skincare.vb</DependentUpon>
    </Compile>
    <Compile Include="skincare.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="SOAN.Designer.vb">
      <DependentUpon>SOAN.vb</DependentUpon>
    </Compile>
    <Compile Include="SOAN.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="soap.Designer.vb">
      <DependentUpon>soap.vb</DependentUpon>
    </Compile>
    <Compile Include="soap.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="soyavitastick.Designer.vb">
      <DependentUpon>soyavitastick.vb</DependentUpon>
    </Compile>
    <Compile Include="soyavitastick.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="spice.Designer.vb">
      <DependentUpon>spice.vb</DependentUpon>
    </Compile>
    <Compile Include="spice.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="suger.Designer.vb">
      <DependentUpon>suger.vb</DependentUpon>
    </Compile>
    <Compile Include="suger.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="syrup.Designer.vb">
      <DependentUpon>syrup.vb</DependentUpon>
    </Compile>
    <Compile Include="syrup.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="toilet.Designer.vb">
      <DependentUpon>toilet.vb</DependentUpon>
    </Compile>
    <Compile Include="toilet.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="toothbrush.Designer.vb">
      <DependentUpon>toothbrush.vb</DependentUpon>
    </Compile>
    <Compile Include="toothbrush.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="toothpaste.Designer.vb">
      <DependentUpon>toothpaste.vb</DependentUpon>
    </Compile>
    <Compile Include="toothpaste.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="toothpowder.Designer.vb">
      <DependentUpon>toothpowder.vb</DependentUpon>
    </Compile>
    <Compile Include="toothpowder.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="vati.Designer.vb">
      <DependentUpon>vati.vb</DependentUpon>
    </Compile>
    <Compile Include="vati.vb">
      <SubType>Form</SubType>
    </Compile>
  </ItemGroup>
  <ItemGroup>
    <EmbeddedResource Include="agervati.resx">
      <DependentUpon>agervati.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="anu.resx">
      <DependentUpon>anu.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="arishta.resx">
      <DependentUpon>arishta.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="asva.resx">
      <DependentUpon>asva.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="bam.resx">
      <DependentUpon>bam.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="Bdaampista.resx">
      <DependentUpon>Bdaampista.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="bdam.resx">
      <DependentUpon>bdam.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="bes.resx">
      <DependentUpon>bes.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="bodycare.resx">
      <DependentUpon>bodycare.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="BROKEN.resx">
      <DependentUpon>BROKEN.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="BURA.resx">
      <DependentUpon>BURA.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="candy.resx">
      <DependentUpon>candy.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="CF.resx">
      <DependentUpon>CF.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="chikki.resx">
      <DependentUpon>chikki.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="childcare.resx">
      <DependentUpon>childcare.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="chips.resx">
      <DependentUpon>chips.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="chy.resx">
      <DependentUpon>chy.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="cold.resx">
      <DependentUpon>cold.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="condi.resx">
      <DependentUpon>condi.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="cream.resx">
      <DependentUpon>cream.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="detergentcake.resx">
      <DependentUpon>detergentcake.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="detergentpowder.resx">
      <DependentUpon>detergentpowder.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="dhoop.resx">
      <DependentUpon>dhoop.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="diet.resx">
      <DependentUpon>diet.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="dig.resx">
      <DependentUpon>dig.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="dishwash.resx">
      <DependentUpon>dishwash.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="eye.resx">
      <DependentUpon>eye.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="facepack.resx">
      <DependentUpon>facepack.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="Facescrub.resx">
      <DependentUpon>Facescrub.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="fashwash.resx">
      <DependentUpon>fashwash.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="fj.resx">
      <DependentUpon>fj.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="bhsma.resx">
      <DependentUpon>bhsma.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="Footcream.resx">
      <DependentUpon>Footcream.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="gajak.resx">
      <DependentUpon>gajak.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="ghi.resx">
      <DependentUpon>ghi.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="godhrk.resx">
      <DependentUpon>godhrk.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="gram.resx">
      <DependentUpon>gram.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="GUGUL.resx">
      <DependentUpon>GUGUL.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="gulcose.resx">
      <DependentUpon>gulcose.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="hand.resx">
      <DependentUpon>hand.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="hawan.resx">
      <DependentUpon>hawan.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="hd.resx">
      <DependentUpon>hd.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="herbalTea.resx">
      <DependentUpon>herbalTea.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="hm.resx">
      <DependentUpon>hm.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="hon.resx">
      <DependentUpon>hon.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="hw.resx">
      <DependentUpon>hw.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="jal.resx">
      <DependentUpon>jal.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="jm.resx">
      <DependentUpon>jm.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="katchup.resx">
      <DependentUpon>katchup.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="katori.resx">
      <DependentUpon>katori.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="kwath.resx">
      <DependentUpon>kwath.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="lotion.resx">
      <DependentUpon>lotion.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="lt.resx">
      <DependentUpon>lt.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="M0IL.resx">
      <DependentUpon>M0IL.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="medic.resx">
      <DependentUpon>medic.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="groc.resx">
      <DependentUpon>groc.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="h.resx">
      <DependentUpon>h.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="mainpage.resx">
      <DependentUpon>mainpage.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="login.resx">
      <DependentUpon>login.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="murrabA.resx">
      <DependentUpon>murrabA.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="My Project\Resources.resx">
      <CustomToolNamespace>My.Resources</CustomToolNamespace>
      <Generator>VbMyResourcesResXFileCodeGenerator</Generator>
      <LastGenOutput>Resources.Designer.vb</LastGenOutput>
    </EmbeddedResource>
    <EmbeddedResource Include="NOODLES.resx">
      <DependentUpon>NOODLES.VB</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="Oatsvb.resx">
      <DependentUpon>Oatsvb.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="oil.resx">
      <DependentUpon>oil.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="papad.resx">
      <DependentUpon>papad.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="parpati.resx">
      <DependentUpon>parpati.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="patanjalchuran.resx">
      <DependentUpon>patanjalchuran.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="patanjlioil.resx">
      <DependentUpon>patanjlioil.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="pers.resx">
      <DependentUpon>pers.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="pic.resx">
      <DependentUpon>pic.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="pishti.resx">
      <DependentUpon>pishti.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="PULSES.resx">
      <DependentUpon>PULSES.VB</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="reg.resx">
      <DependentUpon>reg.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="Rewari.resx">
      <DependentUpon>Rewari.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="RICE.resx">
      <DependentUpon>RICE.VB</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="shampoo.resx">
      <DependentUpon>shampoo.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="shaving.resx">
      <DependentUpon>shaving.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="skincare.resx">
      <DependentUpon>skincare.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="SOAN.resx">
      <DependentUpon>SOAN.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="soap.resx">
      <DependentUpon>soap.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="soyavitastick.resx">
      <DependentUpon>soyavitastick.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="spice.resx">
      <DependentUpon>spice.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="suger.resx">
      <DependentUpon>suger.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="syrup.resx">
      <DependentUpon>syrup.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="toilet.resx">
      <DependentUpon>toilet.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="toothbrush.resx">
      <DependentUpon>toothbrush.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="toothpaste.resx">
      <DependentUpon>toothpaste.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="toothpowder.resx">
      <DependentUpon>toothpowder.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="vati.resx">
      <DependentUpon>vati.vb</DependentUpon>
    </EmbeddedResource>
  </ItemGroup>
  <ItemGroup>
    <None Include="app.config" />
    <None Include="images\shivani\img.w\4070493-cats-in-winter-wallpaper - Shortcut.lnk" />
    <None Include="images\shivani\img.w\day-001-login-form.webp" />
    <None Include="My Project\Application.myapp">
      <Generator>MyApplicationCodeGenerator</Generator>
      <LastGenOutput>Application.Designer.vb</LastGenOutput>
    </None>
    <None Include="My Project\Settings.settings">
      <Generator>SettingsSingleFileGenerator</Generator>
      <CustomToolNamespace>My</CustomToolNamespace>
      <LastGenOutput>Settings.Designer.vb</LastGenOutput>
    </None>
    <None Include="patanjaliDataSet.xsc">
      <DependentUpon>patanjaliDataSet.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet.xsd">
      <Generator>MSDataSetGenerator</Generator>
      <LastGenOutput>patanjaliDataSet.Designer.vb</LastGenOutput>
      <SubType>Designer</SubType>
    </None>
    <None Include="patanjaliDataSet.xss">
      <DependentUpon>patanjaliDataSet.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet1.xsc">
      <DependentUpon>patanjaliDataSet1.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet1.xsd">
      <Generator>MSDataSetGenerator</Generator>
      <LastGenOutput>patanjaliDataSet1.Designer.vb</LastGenOutput>
      <SubType>Designer</SubType>
    </None>
    <None Include="patanjaliDataSet1.xss">
      <DependentUpon>patanjaliDataSet1.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet10.xsc">
      <DependentUpon>patanjaliDataSet10.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet10.xsd">
      <Generator>MSDataSetGenerator</Generator>
      <LastGenOutput>patanjaliDataSet10.Designer.vb</LastGenOutput>
      <SubType>Designer</SubType>
    </None>
    <None Include="patanjaliDataSet10.xss">
      <DependentUpon>patanjaliDataSet10.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet11.xsc">
      <DependentUpon>patanjaliDataSet11.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet11.xsd">
      <Generator>MSDataSetGenerator</Generator>
      <LastGenOutput>patanjaliDataSet11.Designer.vb</LastGenOutput>
      <SubType>Designer</SubType>
    </None>
    <None Include="patanjaliDataSet11.xss">
      <DependentUpon>patanjaliDataSet11.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet12.xsc">
      <DependentUpon>patanjaliDataSet12.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet12.xsd">
      <Generator>MSDataSetGenerator</Generator>
      <LastGenOutput>patanjaliDataSet12.Designer.vb</LastGenOutput>
      <SubType>Designer</SubType>
    </None>
    <None Include="patanjaliDataSet12.xss">
      <DependentUpon>patanjaliDataSet12.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet13.xsc">
      <DependentUpon>patanjaliDataSet13.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet13.xsd">
      <Generator>MSDataSetGenerator</Generator>
      <LastGenOutput>patanjaliDataSet13.Designer.vb</LastGenOutput>
      <SubType>Designer</SubType>
    </None>
    <None Include="patanjaliDataSet13.xss">
      <DependentUpon>patanjaliDataSet13.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet14.xsc">
      <DependentUpon>patanjaliDataSet14.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet14.xsd">
      <Generator>MSDataSetGenerator</Generator>
      <LastGenOutput>patanjaliDataSet14.Designer.vb</LastGenOutput>
      <SubType>Designer</SubType>
    </None>
    <None Include="patanjaliDataSet14.xss">
      <DependentUpon>patanjaliDataSet14.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet15.xsc">
      <DependentUpon>patanjaliDataSet15.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet15.xsd">
      <Generator>MSDataSetGenerator</Generator>
      <LastGenOutput>patanjaliDataSet15.Designer.vb</LastGenOutput>
      <SubType>Designer</SubType>
    </None>
    <None Include="patanjaliDataSet15.xss">
      <DependentUpon>patanjaliDataSet15.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet16.xsc">
      <DependentUpon>patanjaliDataSet16.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet16.xsd">
      <Generator>MSDataSetGenerator</Generator>
      <LastGenOutput>patanjaliDataSet16.Designer.vb</LastGenOutput>
      <SubType>Designer</SubType>
    </None>
    <None Include="patanjaliDataSet16.xss">
      <DependentUpon>patanjaliDataSet16.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet17.xsc">
      <DependentUpon>patanjaliDataSet17.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet17.xsd">
      <Generator>MSDataSetGenerator</Generator>
      <LastGenOutput>patanjaliDataSet17.Designer.vb</LastGenOutput>
      <SubType>Designer</SubType>
    </None>
    <None Include="patanjaliDataSet17.xss">
      <DependentUpon>patanjaliDataSet17.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet18.xsc">
      <DependentUpon>patanjaliDataSet18.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet18.xsd">
      <Generator>MSDataSetGenerator</Generator>
      <LastGenOutput>patanjaliDataSet18.Designer.vb</LastGenOutput>
      <SubType>Designer</SubType>
    </None>
    <None Include="patanjaliDataSet18.xss">
      <DependentUpon>patanjaliDataSet18.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet19.xsc">
      <DependentUpon>patanjaliDataSet19.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet19.xsd">
      <Generator>MSDataSetGenerator</Generator>
      <LastGenOutput>patanjaliDataSet19.Designer.vb</LastGenOutput>
      <SubType>Designer</SubType>
    </None>
    <None Include="patanjaliDataSet19.xss">
      <DependentUpon>patanjaliDataSet19.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet2.xsc">
      <DependentUpon>patanjaliDataSet2.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet2.xsd">
      <Generator>MSDataSetGenerator</Generator>
      <LastGenOutput>patanjaliDataSet2.Designer.vb</LastGenOutput>
      <SubType>Designer</SubType>
    </None>
    <None Include="patanjaliDataSet2.xss">
      <DependentUpon>patanjaliDataSet2.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet20.xsc">
      <DependentUpon>patanjaliDataSet20.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet20.xsd">
      <Generator>MSDataSetGenerator</Generator>
      <LastGenOutput>patanjaliDataSet20.Designer.vb</LastGenOutput>
      <SubType>Designer</SubType>
    </None>
    <None Include="patanjaliDataSet20.xss">
      <DependentUpon>patanjaliDataSet20.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet21.xsc">
      <DependentUpon>patanjaliDataSet21.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet21.xsd">
      <Generator>MSDataSetGenerator</Generator>
      <LastGenOutput>patanjaliDataSet21.Designer.vb</LastGenOutput>
      <SubType>Designer</SubType>
    </None>
    <None Include="patanjaliDataSet21.xss">
      <DependentUpon>patanjaliDataSet21.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet22.xsc">
      <DependentUpon>patanjaliDataSet22.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet22.xsd">
      <Generator>MSDataSetGenerator</Generator>
      <LastGenOutput>patanjaliDataSet22.Designer.vb</LastGenOutput>
      <SubType>Designer</SubType>
    </None>
    <None Include="patanjaliDataSet22.xss">
      <DependentUpon>patanjaliDataSet22.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet23.xsc">
      <DependentUpon>patanjaliDataSet23.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet23.xsd">
      <Generator>MSDataSetGenerator</Generator>
      <LastGenOutput>patanjaliDataSet23.Designer.vb</LastGenOutput>
      <SubType>Designer</SubType>
    </None>
    <None Include="patanjaliDataSet23.xss">
      <DependentUpon>patanjaliDataSet23.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet24.xsc">
      <DependentUpon>patanjaliDataSet24.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet24.xsd">
      <Generator>MSDataSetGenerator</Generator>
      <LastGenOutput>patanjaliDataSet24.Designer.vb</LastGenOutput>
      <SubType>Designer</SubType>
    </None>
    <None Include="patanjaliDataSet24.xss">
      <DependentUpon>patanjaliDataSet24.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet25.xsc">
      <DependentUpon>patanjaliDataSet25.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet25.xsd">
      <Generator>MSDataSetGenerator</Generator>
      <LastGenOutput>patanjaliDataSet25.Designer.vb</LastGenOutput>
      <SubType>Designer</SubType>
    </None>
    <None Include="patanjaliDataSet25.xss">
      <DependentUpon>patanjaliDataSet25.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet26.xsc">
      <DependentUpon>patanjaliDataSet26.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet26.xsd">
      <Generator>MSDataSetGenerator</Generator>
      <LastGenOutput>patanjaliDataSet26.Designer.vb</LastGenOutput>
      <SubType>Designer</SubType>
    </None>
    <None Include="patanjaliDataSet26.xss">
      <DependentUpon>patanjaliDataSet26.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet27.xsc">
      <DependentUpon>patanjaliDataSet27.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet27.xsd">
      <Generator>MSDataSetGenerator</Generator>
      <LastGenOutput>patanjaliDataSet27.Designer.vb</LastGenOutput>
      <SubType>Designer</SubType>
    </None>
    <None Include="patanjaliDataSet27.xss">
      <DependentUpon>patanjaliDataSet27.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet28.xsc">
      <DependentUpon>patanjaliDataSet28.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet28.xsd">
      <Generator>MSDataSetGenerator</Generator>
      <LastGenOutput>patanjaliDataSet28.Designer.vb</LastGenOutput>
      <SubType>Designer</SubType>
    </None>
    <None Include="patanjaliDataSet28.xss">
      <DependentUpon>patanjaliDataSet28.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet29.xsc">
      <DependentUpon>patanjaliDataSet29.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet29.xsd">
      <Generator>MSDataSetGenerator</Generator>
      <LastGenOutput>patanjaliDataSet29.Designer.vb</LastGenOutput>
      <SubType>Designer</SubType>
    </None>
    <None Include="patanjaliDataSet29.xss">
      <DependentUpon>patanjaliDataSet29.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet3.xsc">
      <DependentUpon>patanjaliDataSet3.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet3.xsd">
      <Generator>MSDataSetGenerator</Generator>
      <LastGenOutput>patanjaliDataSet3.Designer.vb</LastGenOutput>
      <SubType>Designer</SubType>
    </None>
    <None Include="patanjaliDataSet3.xss">
      <DependentUpon>patanjaliDataSet3.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet30.xsc">
      <DependentUpon>patanjaliDataSet30.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet30.xsd">
      <Generator>MSDataSetGenerator</Generator>
      <LastGenOutput>patanjaliDataSet30.Designer.vb</LastGenOutput>
      <SubType>Designer</SubType>
    </None>
    <None Include="patanjaliDataSet30.xss">
      <DependentUpon>patanjaliDataSet30.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet31.xsc">
      <DependentUpon>patanjaliDataSet31.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet31.xsd">
      <Generator>MSDataSetGenerator</Generator>
      <LastGenOutput>patanjaliDataSet31.Designer.vb</LastGenOutput>
      <SubType>Designer</SubType>
    </None>
    <None Include="patanjaliDataSet31.xss">
      <DependentUpon>patanjaliDataSet31.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet32.xsc">
      <DependentUpon>patanjaliDataSet32.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet32.xsd">
      <Generator>MSDataSetGenerator</Generator>
      <LastGenOutput>patanjaliDataSet32.Designer.vb</LastGenOutput>
      <SubType>Designer</SubType>
    </None>
    <None Include="patanjaliDataSet32.xss">
      <DependentUpon>patanjaliDataSet32.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet33.xsc">
      <DependentUpon>patanjaliDataSet33.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet33.xsd">
      <Generator>MSDataSetGenerator</Generator>
      <LastGenOutput>patanjaliDataSet33.Designer.vb</LastGenOutput>
      <SubType>Designer</SubType>
    </None>
    <None Include="patanjaliDataSet33.xss">
      <DependentUpon>patanjaliDataSet33.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet34.xsc">
      <DependentUpon>patanjaliDataSet34.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet34.xsd">
      <Generator>MSDataSetGenerator</Generator>
      <LastGenOutput>patanjaliDataSet34.Designer.vb</LastGenOutput>
      <SubType>Designer</SubType>
    </None>
    <None Include="patanjaliDataSet34.xss">
      <DependentUpon>patanjaliDataSet34.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet35.xsc">
      <DependentUpon>patanjaliDataSet35.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet35.xsd">
      <Generator>MSDataSetGenerator</Generator>
      <LastGenOutput>patanjaliDataSet35.Designer.vb</LastGenOutput>
      <SubType>Designer</SubType>
    </None>
    <None Include="patanjaliDataSet35.xss">
      <DependentUpon>patanjaliDataSet35.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet36.xsc">
      <DependentUpon>patanjaliDataSet36.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet36.xsd">
      <Generator>MSDataSetGenerator</Generator>
      <LastGenOutput>patanjaliDataSet36.Designer.vb</LastGenOutput>
      <SubType>Designer</SubType>
    </None>
    <None Include="patanjaliDataSet36.xss">
      <DependentUpon>patanjaliDataSet36.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet37.xsc">
      <DependentUpon>patanjaliDataSet37.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet37.xsd">
      <Generator>MSDataSetGenerator</Generator>
      <LastGenOutput>patanjaliDataSet37.Designer.vb</LastGenOutput>
      <SubType>Designer</SubType>
    </None>
    <None Include="patanjaliDataSet37.xss">
      <DependentUpon>patanjaliDataSet37.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet38.xsc">
      <DependentUpon>patanjaliDataSet38.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet38.xsd">
      <Generator>MSDataSetGenerator</Generator>
      <LastGenOutput>patanjaliDataSet38.Designer.vb</LastGenOutput>
      <SubType>Designer</SubType>
    </None>
    <None Include="patanjaliDataSet38.xss">
      <DependentUpon>patanjaliDataSet38.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet39.xsc">
      <DependentUpon>patanjaliDataSet39.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet39.xsd">
      <Generator>MSDataSetGenerator</Generator>
      <LastGenOutput>patanjaliDataSet39.Designer.vb</LastGenOutput>
      <SubType>Designer</SubType>
    </None>
    <None Include="patanjaliDataSet39.xss">
      <DependentUpon>patanjaliDataSet39.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet4.xsc">
      <DependentUpon>patanjaliDataSet4.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet4.xsd">
      <Generator>MSDataSetGenerator</Generator>
      <LastGenOutput>patanjaliDataSet4.Designer.vb</LastGenOutput>
      <SubType>Designer</SubType>
    </None>
    <None Include="patanjaliDataSet4.xss">
      <DependentUpon>patanjaliDataSet4.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet40.xsc">
      <DependentUpon>patanjaliDataSet40.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet40.xsd">
      <Generator>MSDataSetGenerator</Generator>
      <LastGenOutput>patanjaliDataSet40.Designer.vb</LastGenOutput>
      <SubType>Designer</SubType>
    </None>
    <None Include="patanjaliDataSet40.xss">
      <DependentUpon>patanjaliDataSet40.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet41.xsc">
      <DependentUpon>patanjaliDataSet41.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet41.xsd">
      <Generator>MSDataSetGenerator</Generator>
      <LastGenOutput>patanjaliDataSet41.Designer.vb</LastGenOutput>
      <SubType>Designer</SubType>
    </None>
    <None Include="patanjaliDataSet41.xss">
      <DependentUpon>patanjaliDataSet41.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet42.xsc">
      <DependentUpon>patanjaliDataSet42.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet42.xsd">
      <Generator>MSDataSetGenerator</Generator>
      <LastGenOutput>patanjaliDataSet42.Designer.vb</LastGenOutput>
      <SubType>Designer</SubType>
    </None>
    <None Include="patanjaliDataSet42.xss">
      <DependentUpon>patanjaliDataSet42.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet43.xsc">
      <DependentUpon>patanjaliDataSet43.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet43.xsd">
      <Generator>MSDataSetGenerator</Generator>
      <LastGenOutput>patanjaliDataSet43.Designer.vb</LastGenOutput>
      <SubType>Designer</SubType>
    </None>
    <None Include="patanjaliDataSet43.xss">
      <DependentUpon>patanjaliDataSet43.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet44.xsc">
      <DependentUpon>patanjaliDataSet44.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet44.xsd">
      <Generator>MSDataSetGenerator</Generator>
      <LastGenOutput>patanjaliDataSet44.Designer.vb</LastGenOutput>
      <SubType>Designer</SubType>
    </None>
    <None Include="patanjaliDataSet44.xss">
      <DependentUpon>patanjaliDataSet44.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet45.xsc">
      <DependentUpon>patanjaliDataSet45.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet45.xsd">
      <Generator>MSDataSetGenerator</Generator>
      <LastGenOutput>patanjaliDataSet45.Designer.vb</LastGenOutput>
      <SubType>Designer</SubType>
    </None>
    <None Include="patanjaliDataSet45.xss">
      <DependentUpon>patanjaliDataSet45.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet46.xsc">
      <DependentUpon>patanjaliDataSet46.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet46.xsd">
      <Generator>MSDataSetGenerator</Generator>
      <LastGenOutput>patanjaliDataSet46.Designer.vb</LastGenOutput>
      <SubType>Designer</SubType>
    </None>
    <None Include="patanjaliDataSet46.xss">
      <DependentUpon>patanjaliDataSet46.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet47.xsc">
      <DependentUpon>patanjaliDataSet47.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet47.xsd">
      <Generator>MSDataSetGenerator</Generator>
      <LastGenOutput>patanjaliDataSet47.Designer.vb</LastGenOutput>
      <SubType>Designer</SubType>
    </None>
    <None Include="patanjaliDataSet47.xss">
      <DependentUpon>patanjaliDataSet47.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet48.xsc">
      <DependentUpon>patanjaliDataSet48.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet48.xsd">
      <Generator>MSDataSetGenerator</Generator>
      <LastGenOutput>patanjaliDataSet48.Designer.vb</LastGenOutput>
      <SubType>Designer</SubType>
    </None>
    <None Include="patanjaliDataSet48.xss">
      <DependentUpon>patanjaliDataSet48.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet49.xsc">
      <DependentUpon>patanjaliDataSet49.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet49.xsd">
      <Generator>MSDataSetGenerator</Generator>
      <LastGenOutput>patanjaliDataSet49.Designer.vb</LastGenOutput>
      <SubType>Designer</SubType>
    </None>
    <None Include="patanjaliDataSet49.xss">
      <DependentUpon>patanjaliDataSet49.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet5.xsc">
      <DependentUpon>patanjaliDataSet5.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet5.xsd">
      <Generator>MSDataSetGenerator</Generator>
      <LastGenOutput>patanjaliDataSet5.Designer.vb</LastGenOutput>
      <SubType>Designer</SubType>
    </None>
    <None Include="patanjaliDataSet5.xss">
      <DependentUpon>patanjaliDataSet5.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet50.xsc">
      <DependentUpon>patanjaliDataSet50.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet50.xsd">
      <Generator>MSDataSetGenerator</Generator>
      <LastGenOutput>patanjaliDataSet50.Designer.vb</LastGenOutput>
      <SubType>Designer</SubType>
    </None>
    <None Include="patanjaliDataSet50.xss">
      <DependentUpon>patanjaliDataSet50.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet51.xsc">
      <DependentUpon>patanjaliDataSet51.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet51.xsd">
      <Generator>MSDataSetGenerator</Generator>
      <LastGenOutput>patanjaliDataSet51.Designer.vb</LastGenOutput>
      <SubType>Designer</SubType>
    </None>
    <None Include="patanjaliDataSet51.xss">
      <DependentUpon>patanjaliDataSet51.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet52.xsc">
      <DependentUpon>patanjaliDataSet52.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet52.xsd">
      <Generator>MSDataSetGenerator</Generator>
      <LastGenOutput>patanjaliDataSet52.Designer.vb</LastGenOutput>
      <SubType>Designer</SubType>
    </None>
    <None Include="patanjaliDataSet52.xss">
      <DependentUpon>patanjaliDataSet52.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet53.xsc">
      <DependentUpon>patanjaliDataSet53.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet53.xsd">
      <Generator>MSDataSetGenerator</Generator>
      <LastGenOutput>patanjaliDataSet53.Designer.vb</LastGenOutput>
      <SubType>Designer</SubType>
    </None>
    <None Include="patanjaliDataSet53.xss">
      <DependentUpon>patanjaliDataSet53.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet54.xsc">
      <DependentUpon>patanjaliDataSet54.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet54.xsd">
      <Generator>MSDataSetGenerator</Generator>
      <LastGenOutput>patanjaliDataSet54.Designer.vb</LastGenOutput>
      <SubType>Designer</SubType>
    </None>
    <None Include="patanjaliDataSet54.xss">
      <DependentUpon>patanjaliDataSet54.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet55.xsc">
      <DependentUpon>patanjaliDataSet55.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet55.xsd">
      <Generator>MSDataSetGenerator</Generator>
      <LastGenOutput>patanjaliDataSet55.Designer.vb</LastGenOutput>
      <SubType>Designer</SubType>
    </None>
    <None Include="patanjaliDataSet55.xss">
      <DependentUpon>patanjaliDataSet55.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet56.xsc">
      <DependentUpon>patanjaliDataSet56.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet56.xsd">
      <Generator>MSDataSetGenerator</Generator>
      <LastGenOutput>patanjaliDataSet56.Designer.vb</LastGenOutput>
      <SubType>Designer</SubType>
    </None>
    <None Include="patanjaliDataSet56.xss">
      <DependentUpon>patanjaliDataSet56.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet57.xsc">
      <DependentUpon>patanjaliDataSet57.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet57.xsd">
      <Generator>MSDataSetGenerator</Generator>
      <LastGenOutput>patanjaliDataSet57.Designer.vb</LastGenOutput>
      <SubType>Designer</SubType>
    </None>
    <None Include="patanjaliDataSet57.xss">
      <DependentUpon>patanjaliDataSet57.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet58.xsc">
      <DependentUpon>patanjaliDataSet58.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet58.xsd">
      <Generator>MSDataSetGenerator</Generator>
      <LastGenOutput>patanjaliDataSet58.Designer.vb</LastGenOutput>
      <SubType>Designer</SubType>
    </None>
    <None Include="patanjaliDataSet58.xss">
      <DependentUpon>patanjaliDataSet58.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet59.xsc">
      <DependentUpon>patanjaliDataSet59.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet59.xsd">
      <Generator>MSDataSetGenerator</Generator>
      <LastGenOutput>patanjaliDataSet59.Designer.vb</LastGenOutput>
      <SubType>Designer</SubType>
    </None>
    <None Include="patanjaliDataSet59.xss">
      <DependentUpon>patanjaliDataSet59.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet6.xsc">
      <DependentUpon>patanjaliDataSet6.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet6.xsd">
      <Generator>MSDataSetGenerator</Generator>
      <LastGenOutput>patanjaliDataSet6.Designer.vb</LastGenOutput>
      <SubType>Designer</SubType>
    </None>
    <None Include="patanjaliDataSet6.xss">
      <DependentUpon>patanjaliDataSet6.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet60.xsc">
      <DependentUpon>patanjaliDataSet60.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet60.xsd">
      <Generator>MSDataSetGenerator</Generator>
      <LastGenOutput>patanjaliDataSet60.Designer.vb</LastGenOutput>
      <SubType>Designer</SubType>
    </None>
    <None Include="patanjaliDataSet60.xss">
      <DependentUpon>patanjaliDataSet60.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet61.xsc">
      <DependentUpon>patanjaliDataSet61.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet61.xsd">
      <Generator>MSDataSetGenerator</Generator>
      <LastGenOutput>patanjaliDataSet61.Designer.vb</LastGenOutput>
      <SubType>Designer</SubType>
    </None>
    <None Include="patanjaliDataSet61.xss">
      <DependentUpon>patanjaliDataSet61.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet62.xsc">
      <DependentUpon>patanjaliDataSet62.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet62.xsd">
      <Generator>MSDataSetGenerator</Generator>
      <LastGenOutput>patanjaliDataSet62.Designer.vb</LastGenOutput>
      <SubType>Designer</SubType>
    </None>
    <None Include="patanjaliDataSet62.xss">
      <DependentUpon>patanjaliDataSet62.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet63.xsc">
      <DependentUpon>patanjaliDataSet63.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet63.xsd">
      <Generator>MSDataSetGenerator</Generator>
      <LastGenOutput>patanjaliDataSet63.Designer.vb</LastGenOutput>
      <SubType>Designer</SubType>
    </None>
    <None Include="patanjaliDataSet63.xss">
      <DependentUpon>patanjaliDataSet63.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet64.xsc">
      <DependentUpon>patanjaliDataSet64.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet64.xsd">
      <Generator>MSDataSetGenerator</Generator>
      <LastGenOutput>patanjaliDataSet64.Designer.vb</LastGenOutput>
      <SubType>Designer</SubType>
    </None>
    <None Include="patanjaliDataSet64.xss">
      <DependentUpon>patanjaliDataSet64.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet65.xsc">
      <DependentUpon>patanjaliDataSet65.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet65.xsd">
      <Generator>MSDataSetGenerator</Generator>
      <LastGenOutput>patanjaliDataSet65.Designer.vb</LastGenOutput>
      <SubType>Designer</SubType>
    </None>
    <None Include="patanjaliDataSet65.xss">
      <DependentUpon>patanjaliDataSet65.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet66.xsc">
      <DependentUpon>patanjaliDataSet66.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet66.xsd">
      <Generator>MSDataSetGenerator</Generator>
      <LastGenOutput>patanjaliDataSet66.Designer.vb</LastGenOutput>
      <SubType>Designer</SubType>
    </None>
    <None Include="patanjaliDataSet66.xss">
      <DependentUpon>patanjaliDataSet66.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet67.xsc">
      <DependentUpon>patanjaliDataSet67.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet67.xsd">
      <Generator>MSDataSetGenerator</Generator>
      <LastGenOutput>patanjaliDataSet67.Designer.vb</LastGenOutput>
      <SubType>Designer</SubType>
    </None>
    <None Include="patanjaliDataSet67.xss">
      <DependentUpon>patanjaliDataSet67.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet68.xsc">
      <DependentUpon>patanjaliDataSet68.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet68.xsd">
      <Generator>MSDataSetGenerator</Generator>
      <LastGenOutput>patanjaliDataSet68.Designer.vb</LastGenOutput>
      <SubType>Designer</SubType>
    </None>
    <None Include="patanjaliDataSet68.xss">
      <DependentUpon>patanjaliDataSet68.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet69.xsc">
      <DependentUpon>patanjaliDataSet69.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet69.xsd">
      <Generator>MSDataSetGenerator</Generator>
      <LastGenOutput>patanjaliDataSet69.Designer.vb</LastGenOutput>
      <SubType>Designer</SubType>
    </None>
    <None Include="patanjaliDataSet69.xss">
      <DependentUpon>patanjaliDataSet69.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet7.xsc">
      <DependentUpon>patanjaliDataSet7.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet7.xsd">
      <Generator>MSDataSetGenerator</Generator>
      <LastGenOutput>patanjaliDataSet7.Designer.vb</LastGenOutput>
      <SubType>Designer</SubType>
    </None>
    <None Include="patanjaliDataSet7.xss">
      <DependentUpon>patanjaliDataSet7.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet70.xsc">
      <DependentUpon>patanjaliDataSet70.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet70.xsd">
      <Generator>MSDataSetGenerator</Generator>
      <LastGenOutput>patanjaliDataSet70.Designer.vb</LastGenOutput>
      <SubType>Designer</SubType>
    </None>
    <None Include="patanjaliDataSet70.xss">
      <DependentUpon>patanjaliDataSet70.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet71.xsc">
      <DependentUpon>patanjaliDataSet71.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet71.xsd">
      <Generator>MSDataSetGenerator</Generator>
      <LastGenOutput>patanjaliDataSet71.Designer.vb</LastGenOutput>
      <SubType>Designer</SubType>
    </None>
    <None Include="patanjaliDataSet71.xss">
      <DependentUpon>patanjaliDataSet71.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet72.xsc">
      <DependentUpon>patanjaliDataSet72.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet72.xsd">
      <Generator>MSDataSetGenerator</Generator>
      <LastGenOutput>patanjaliDataSet72.Designer.vb</LastGenOutput>
      <SubType>Designer</SubType>
    </None>
    <None Include="patanjaliDataSet72.xss">
      <DependentUpon>patanjaliDataSet72.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet73.xsc">
      <DependentUpon>patanjaliDataSet73.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet73.xsd">
      <Generator>MSDataSetGenerator</Generator>
      <LastGenOutput>patanjaliDataSet73.Designer.vb</LastGenOutput>
      <SubType>Designer</SubType>
    </None>
    <None Include="patanjaliDataSet73.xss">
      <DependentUpon>patanjaliDataSet73.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet74.xsc">
      <DependentUpon>patanjaliDataSet74.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet74.xsd">
      <Generator>MSDataSetGenerator</Generator>
      <LastGenOutput>patanjaliDataSet74.Designer.vb</LastGenOutput>
      <SubType>Designer</SubType>
    </None>
    <None Include="patanjaliDataSet74.xss">
      <DependentUpon>patanjaliDataSet74.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet75.xsc">
      <DependentUpon>patanjaliDataSet75.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet75.xsd">
      <Generator>MSDataSetGenerator</Generator>
      <LastGenOutput>patanjaliDataSet75.Designer.vb</LastGenOutput>
      <SubType>Designer</SubType>
    </None>
    <None Include="patanjaliDataSet75.xss">
      <DependentUpon>patanjaliDataSet75.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet76.xsc">
      <DependentUpon>patanjaliDataSet76.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet76.xsd">
      <Generator>MSDataSetGenerator</Generator>
      <LastGenOutput>patanjaliDataSet76.Designer.vb</LastGenOutput>
      <SubType>Designer</SubType>
    </None>
    <None Include="patanjaliDataSet76.xss">
      <DependentUpon>patanjaliDataSet76.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet77.xsc">
      <DependentUpon>patanjaliDataSet77.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet77.xsd">
      <Generator>MSDataSetGenerator</Generator>
      <LastGenOutput>patanjaliDataSet77.Designer.vb</LastGenOutput>
      <SubType>Designer</SubType>
    </None>
    <None Include="patanjaliDataSet77.xss">
      <DependentUpon>patanjaliDataSet77.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet78.xsc">
      <DependentUpon>patanjaliDataSet78.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet78.xsd">
      <Generator>MSDataSetGenerator</Generator>
      <LastGenOutput>patanjaliDataSet78.Designer.vb</LastGenOutput>
      <SubType>Designer</SubType>
    </None>
    <None Include="patanjaliDataSet78.xss">
      <DependentUpon>patanjaliDataSet78.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet79.xsc">
      <DependentUpon>patanjaliDataSet79.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet79.xsd">
      <Generator>MSDataSetGenerator</Generator>
      <LastGenOutput>patanjaliDataSet79.Designer.vb</LastGenOutput>
      <SubType>Designer</SubType>
    </None>
    <None Include="patanjaliDataSet79.xss">
      <DependentUpon>patanjaliDataSet79.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet8.xsc">
      <DependentUpon>patanjaliDataSet8.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet8.xsd">
      <Generator>MSDataSetGenerator</Generator>
      <LastGenOutput>patanjaliDataSet8.Designer.vb</LastGenOutput>
      <SubType>Designer</SubType>
    </None>
    <None Include="patanjaliDataSet8.xss">
      <DependentUpon>patanjaliDataSet8.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet80.xsc">
      <DependentUpon>patanjaliDataSet80.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet80.xsd">
      <Generator>MSDataSetGenerator</Generator>
      <LastGenOutput>patanjaliDataSet80.Designer.vb</LastGenOutput>
      <SubType>Designer</SubType>
    </None>
    <None Include="patanjaliDataSet80.xss">
      <DependentUpon>patanjaliDataSet80.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet81.xsc">
      <DependentUpon>patanjaliDataSet81.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet81.xsd">
      <Generator>MSDataSetGenerator</Generator>
      <LastGenOutput>patanjaliDataSet81.Designer.vb</LastGenOutput>
      <SubType>Designer</SubType>
    </None>
    <None Include="patanjaliDataSet81.xss">
      <DependentUpon>patanjaliDataSet81.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet82.xsc">
      <DependentUpon>patanjaliDataSet82.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet82.xsd">
      <Generator>MSDataSetGenerator</Generator>
      <LastGenOutput>patanjaliDataSet82.Designer.vb</LastGenOutput>
      <SubType>Designer</SubType>
    </None>
    <None Include="patanjaliDataSet82.xss">
      <DependentUpon>patanjaliDataSet82.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet83.xsc">
      <DependentUpon>patanjaliDataSet83.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet83.xsd">
      <Generator>MSDataSetGenerator</Generator>
      <LastGenOutput>patanjaliDataSet83.Designer.vb</LastGenOutput>
      <SubType>Designer</SubType>
    </None>
    <None Include="patanjaliDataSet83.xss">
      <DependentUpon>patanjaliDataSet83.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet84.xsc">
      <DependentUpon>patanjaliDataSet84.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet84.xsd">
      <Generator>MSDataSetGenerator</Generator>
      <LastGenOutput>patanjaliDataSet84.Designer.vb</LastGenOutput>
      <SubType>Designer</SubType>
    </None>
    <None Include="patanjaliDataSet84.xss">
      <DependentUpon>patanjaliDataSet84.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet9.xsc">
      <DependentUpon>patanjaliDataSet9.xsd</DependentUpon>
    </None>
    <None Include="patanjaliDataSet9.xsd">
      <Generator>MSDataSetGenerator</Generator>
      <LastGenOutput>patanjaliDataSet9.Designer.vb</LastGenOutput>
      <SubType>Designer</SubType>
    </None>
    <None Include="patanjaliDataSet9.xss">
      <DependentUpon>patanjaliDataSet9.xsd</DependentUpon>
    </None>
  </ItemGroup>
  <ItemGroup>
    <BootstrapperPackage Include=".NETFramework,Version=v4.0,Profile=Client">
      <Visible>False</Visible>
      <ProductName>Microsoft .NET Framework 4 Client Profile %28x86 and x64%29</ProductName>
      <Install>true</Install>
    </BootstrapperPackage>
    <BootstrapperPackage Include="Microsoft.Net.Client.3.5">
      <Visible>False</Visible>
      <ProductName>.NET Framework 3.5 SP1 Client Profile</ProductName>
      <Install>false</Install>
    </BootstrapperPackage>
    <BootstrapperPackage Include="Microsoft.Net.Framework.3.5.SP1">
      <Visible>False</Visible>
      <ProductName>.NET Framework 3.5 SP1</ProductName>
      <Install>false</Install>
    </BootstrapperPackage>
    <BootstrapperPackage Include="Microsoft.Sql.Server.Express.10.0">
      <Visible>False</Visible>
      <ProductName>SQL Server 2008 Express</ProductName>
      <Install>true</Install>
    </BootstrapperPackage>
    <BootstrapperPackage Include="Microsoft.Windows.Installer.3.1">
      <Visible>False</Visible>
      <ProductName>Windows Installer 3.1</ProductName>
      <Install>true</Install>
    </BootstrapperPackage>
    <BootstrapperPackage Include="Microsoft.Windows.Installer.4.5">
      <Visible>False</Visible>
      <ProductName>Windows Installer 4.5</ProductName>
      <Install>true</Install>
    </BootstrapperPackage>
  </ItemGroup>
  <ItemGroup>
    <Content Include="images\shivani\11-Patanjali-Neem-Kanti-Body-Cleanser-Soap-1.jpg" />
    <Content Include="images\shivani\13047-patanjali-fssai.jpg" />
    <Content Include="images\shivani\925790092s.png" />
    <Content Include="images\shivani\bunch.png" />
    <Content Include="images\shivani\butterflies_texture_background_pattern_9681_2560x1600.jpg" />
    <Content Include="images\shivani\img.w\1046390-winter-wallpaper-hd.jpg" />
    <Content Include="images\shivani\img.w\1469089961cfd991c6d9f609d5e6584a69287d5a39.jpg" />
    <Content Include="images\shivani\img.w\17023.jpg" />
    <Content Include="images\shivani\img.w\3574641-transparent-wallpapers.jpg" />
    <Content Include="images\shivani\img.w\3d-digital-design-widescreen-wallpaper_1920x1200_86479.jpg" />
    <Content Include="images\shivani\img.w\3d-simple-background-wallpapers-hd--desktop-and-mobile-backgrounds-18.jpeg" />
    <Content Include="images\shivani\img.w\4070493-cats-in-winter-wallpaper.jpg" />
    <Content Include="images\shivani\img.w\4ae8c9fccd882109292886398e30b1e8--iphone--wallpaper-wallpaper-backgrounds.jpg" />
    <Content Include="images\shivani\img.w\554659-3d-abstract-floating-lighting-meteorite-rocks-simple-background-spheres.jpg" />
    <Content Include="images\shivani\img.w\6006.jpg" />
    <Content Include="images\shivani\img.w\704695_simple-simple-backgrounds-hd-backgrounds-walldevil-best-free-hd_1920x1080_h.jpg" />
    <Content Include="images\shivani\img.w\704705_light-minimalistic-vignette-simple-backgrounds-wallpapers_1920x1080_h.jpg" />
    <Content Include="images\shivani\img.w\712f19fd0eec5a3e351849676681d9cc.jpg" />
    <Content Include="images\shivani\img.w\a9ab54d4eb844a31ce50ffb724ddd754.jpg" />
    <Content Include="images\shivani\img.w\ayurveda-medicines_0.jpg" />
    <Content Include="images\shivani\img.w\ayurveda_medicine-966x483.jpg" />
    <Content Include="images\shivani\img.w\background-2887350_960_720.jpg" />
    <Content Include="images\shivani\img.w\blue_background_wave_abstract_77125_3840x2400.jpg" />
    <Content Include="images\shivani\img.w\christmas_lights_photography_hd_wallpapers.jpg" />
    <Content Include="images\shivani\img.w\d0a1332e7cec4b6db6d96eaa7ad6a955--red-wallpaper-pc-computer.jpg" />
    <Content Include="images\shivani\img.w\download %281%29.jpg" />
    <Content Include="images\shivani\img.w\download %281%29.png" />
    <Content Include="images\shivani\img.w\download %282%29.jpg" />
    <Content Include="images\shivani\img.w\download %282%29.png" />
    <Content Include="images\shivani\img.w\download.jpg" />
    <Content Include="images\shivani\img.w\download.png" />
    <Content Include="images\shivani\img.w\free-wallpaper-05.jpg" />
    <Content Include="images\shivani\img.w\glow_wave_abstract_background_51907_300x187.jpg" />
    <Content Include="images\shivani\img.w\images %281%29.jpg" />
    <Content Include="images\shivani\img.w\images %2810%29.jpg" />
    <Content Include="images\shivani\img.w\images %282%29.jpg" />
    <Content Include="images\shivani\img.w\images %283%29.jpg" />
    <Content Include="images\shivani\img.w\images %284%29.jpg" />
    <Content Include="images\shivani\img.w\images %285%29.jpg" />
    <Content Include="images\shivani\img.w\images %286%29.jpg" />
    <Content Include="images\shivani\img.w\images %287%29.jpg" />
    <Content Include="images\shivani\img.w\images %288%29.jpg" />
    <Content Include="images\shivani\img.w\images %289%29.jpg" />
    <Content Include="images\shivani\img.w\images.jpg" />
    <Content Include="images\shivani\img.w\images.png" />
    <Content Include="images\shivani\img.w\marketing-and-selling-personal-care-products.jpg" />
    <Content Include="images\shivani\img.w\openbook-blank-page-hd-wallpaper-1920x1200.jpg" />
    <Content Include="images\shivani\img.w\Pink-Butterfly-Design.gif" />
    <Content Include="images\shivani\img.w\Shine-beautiful-abstract-background-wallpapers.jpg" />
    <Content Include="images\shivani\img.w\simple-background-purple-720P-wallpaper-middle-size.jpg" />
    <Content Include="images\shivani\img.w\Simple-Butterfly-Design.jpg" />
    <Content Include="images\shivani\img.w\simple_gradient_wallpaper_by_adammburleighphoto-d54upk7.png" />
    <Content Include="images\shivani\img.w\What-is-Ayurveda.jpg" />
    <Content Include="images\shivani\img.w\winter-background-hd-40.jpg" />
    <Content Include="images\shivani\img.w\zen_stones_background-wallpaper-1280x720-1024x576.jpg" />
    <Content Include="patanjali.mdf">
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </Content>
    <Content Include="patanjali_log.ldf">
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
      <DependentUpon>patanjali.mdf</DependentUpon>
    </Content>
  </ItemGroup>
  <Import Project="$(MSBuildToolsPath)\Microsoft.VisualBasic.targets" />
  <!-- To modify your build process, add your task inside one of the targets below and uncomment it. 
       Other similar extension points exist, see Microsoft.Common.targets.
  <Target Name="BeforeBuild">
  </Target>
  <Target Name="AfterBuild">
  </Target>
  -->
</Project>