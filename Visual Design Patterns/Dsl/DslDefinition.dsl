<?xml version="1.0" encoding="utf-8"?>
<Dsl xmlns:dm0="http://schemas.microsoft.com/VisualStudio/2008/DslTools/Core" dslVersion="1.0.0.0" Id="c118fd14-74b8-4bd3-9c91-53ab17304d6f" Description="Description for VisualDesignPatterns.Desi" Name="Desi" DisplayName="Desi" Namespace="VisualDesignPatterns" ProductName="Visual Design Patterns" CompanyName="Shirish Goyal" PackageGuid="f8a64ea5-4c0f-4711-b312-2e617c9389c4" PackageNamespace="VisualDesignPatterns" xmlns="http://schemas.microsoft.com/VisualStudio/2005/DslTools/DslDefinitionModel">
  <Classes>
    <DomainClass Id="ada1f7a1-7c41-4c09-a8c8-56cd23a0ca89" Description="The root in which all other elements are embedded. Appears as a diagram." Name="Design" DisplayName="Design" Namespace="VisualDesignPatterns">
      <Properties>
        <DomainProperty Id="7b39fde8-37a2-4681-be7c-bcb93a720eba" Description="Description for VisualDesignPatterns.Design.Name" Name="Name" DisplayName="Name">
          <Type>
            <ExternalTypeMoniker Name="/System/String" />
          </Type>
        </DomainProperty>
      </Properties>
      <ElementMergeDirectives>
        <ElementMergeDirective>
          <Notes>Creates an embedding link when an element is dropped onto a model. </Notes>
          <Index>
            <DomainClassMoniker Name="DesignPattern" />
          </Index>
          <LinkCreationPaths>
            <DomainPath>DesignHasDesignPatterns.DesignPatterns</DomainPath>
          </LinkCreationPaths>
        </ElementMergeDirective>
      </ElementMergeDirectives>
    </DomainClass>
    <DomainClass Id="9a056058-3b3c-49f3-a71a-351a5d858fe4" Description="Elements embedded in the model. Appear as boxes on the diagram." Name="DesignPattern" DisplayName="Design Pattern" Namespace="VisualDesignPatterns">
      <Properties>
        <DomainProperty Id="99a9cd97-2883-48a9-80a0-529eec847a05" Description="Description for VisualDesignPatterns.DesignPattern.Name" Name="Name" DisplayName="Name" DefaultValue="" IsElementName="true">
          <Type>
            <ExternalTypeMoniker Name="/System/String" />
          </Type>
        </DomainProperty>
        <DomainProperty Id="3c79500c-0fde-488f-8f5b-2124f28719d8" Description="Description for VisualDesignPatterns.DesignPattern.Classification" Name="Classification" DisplayName="Classification" DefaultValue="">
          <Type>
            <DomainEnumerationMoniker Name="PatternClassification" />
          </Type>
        </DomainProperty>
      </Properties>
      <ElementMergeDirectives>
        <ElementMergeDirective>
          <Index>
            <DomainClassMoniker Name="AbstractClass" />
          </Index>
          <LinkCreationPaths>
            <DomainPath>DesignPatternHasAbstractClasses.AbstractClasses</DomainPath>
          </LinkCreationPaths>
        </ElementMergeDirective>
        <ElementMergeDirective>
          <Index>
            <DomainClassMoniker Name="ConcreteClass" />
          </Index>
          <LinkCreationPaths>
            <DomainPath>DesignPatternHasConcreteClasses.ConcreteClasses</DomainPath>
          </LinkCreationPaths>
        </ElementMergeDirective>
      </ElementMergeDirectives>
    </DomainClass>
    <DomainClass Id="dcbc7bd5-8653-4779-8931-c26a273ac8d6" Description="Description for VisualDesignPatterns.AbstractClass" Name="AbstractClass" DisplayName="Abstract Class" Namespace="VisualDesignPatterns">
      <Properties>
        <DomainProperty Id="10c3ebfd-3629-4cf9-a5ed-0c1bb3180ec2" Description="Description for VisualDesignPatterns.AbstractClass.Name" Name="Name" DisplayName="Name" IsElementName="true">
          <Type>
            <ExternalTypeMoniker Name="/System/String" />
          </Type>
        </DomainProperty>
      </Properties>
    </DomainClass>
    <DomainClass Id="c9e53612-f0e0-48a8-a046-ebcc4292ede2" Description="Description for VisualDesignPatterns.ConcreteClass" Name="ConcreteClass" DisplayName="Concrete Class" Namespace="VisualDesignPatterns">
      <Properties>
        <DomainProperty Id="5b379028-7f5e-499a-93ea-62a543f762f8" Description="Description for VisualDesignPatterns.ConcreteClass.Name" Name="Name" DisplayName="Name">
          <Type>
            <ExternalTypeMoniker Name="/System/String" />
          </Type>
        </DomainProperty>
      </Properties>
    </DomainClass>
    <DomainClass Id="91b57448-4433-477a-b489-60a5fb68bbe7" Description="Description for VisualDesignPatterns.ConcreteObject" Name="ConcreteObject" DisplayName="Concrete Object" Namespace="VisualDesignPatterns" />
  </Classes>
  <Relationships>
    <DomainRelationship Id="e6919f8f-4d2a-4fe0-ac21-fd6df44fcede" Description="Embedding relationship between the Model and Elements" Name="DesignHasDesignPatterns" DisplayName="Design Has Design Patterns" Namespace="VisualDesignPatterns" IsEmbedding="true">
      <Source>
        <DomainRole Id="0d05f3f9-809d-4dcb-a6fc-25f073fe0f4d" Description="" Name="Design" DisplayName="Design" PropertyName="DesignPatterns" PropagatesCopy="PropagatesCopyToLinkAndOppositeRolePlayer" PropertyDisplayName="Design Patterns">
          <RolePlayer>
            <DomainClassMoniker Name="Design" />
          </RolePlayer>
        </DomainRole>
      </Source>
      <Target>
        <DomainRole Id="1430deb8-fdda-43b0-ace3-d29e17b2ec86" Description="" Name="Element" DisplayName="Element" PropertyName="Design" Multiplicity="One" PropagatesDelete="true" PropertyDisplayName="Design">
          <RolePlayer>
            <DomainClassMoniker Name="DesignPattern" />
          </RolePlayer>
        </DomainRole>
      </Target>
    </DomainRelationship>
    <DomainRelationship Id="15f3b78e-defb-465f-bcb2-ebdd453eb711" Description="Description for VisualDesignPatterns.DesignPatternHasAbstractClasses" Name="DesignPatternHasAbstractClasses" DisplayName="Design Pattern Has Abstract Classes" Namespace="VisualDesignPatterns" IsEmbedding="true">
      <Source>
        <DomainRole Id="f20d92c7-036a-4c57-8ddc-231c8672bc0b" Description="Description for VisualDesignPatterns.DesignPatternHasAbstractClasses.DesignPattern" Name="DesignPattern" DisplayName="Design Pattern" PropertyName="AbstractClasses" PropagatesCopy="PropagatesCopyToLinkAndOppositeRolePlayer" PropertyDisplayName="Abstract Classes">
          <RolePlayer>
            <DomainClassMoniker Name="DesignPattern" />
          </RolePlayer>
        </DomainRole>
      </Source>
      <Target>
        <DomainRole Id="a5a3da9c-cf81-4084-92fc-648741880b99" Description="Description for VisualDesignPatterns.DesignPatternHasAbstractClasses.AbstractClass" Name="AbstractClass" DisplayName="Abstract Class" PropertyName="DesignPattern" Multiplicity="One" PropagatesDelete="true" PropertyDisplayName="Design Pattern">
          <RolePlayer>
            <DomainClassMoniker Name="AbstractClass" />
          </RolePlayer>
        </DomainRole>
      </Target>
    </DomainRelationship>
    <DomainRelationship Id="9c4fac4c-2788-4260-b59e-32f339a5b374" Description="Description for VisualDesignPatterns.DesignPatternHasConcreteClasses" Name="DesignPatternHasConcreteClasses" DisplayName="Design Pattern Has Concrete Classes" Namespace="VisualDesignPatterns" IsEmbedding="true">
      <Source>
        <DomainRole Id="405711dd-feda-45be-a903-a381d45ba916" Description="Description for VisualDesignPatterns.DesignPatternHasConcreteClasses.DesignPattern" Name="DesignPattern" DisplayName="Design Pattern" PropertyName="ConcreteClasses" PropagatesCopy="PropagatesCopyToLinkAndOppositeRolePlayer" PropertyDisplayName="Concrete Classes">
          <RolePlayer>
            <DomainClassMoniker Name="DesignPattern" />
          </RolePlayer>
        </DomainRole>
      </Source>
      <Target>
        <DomainRole Id="e2e31e3b-0ce5-4ad0-a91e-a918e699712e" Description="Description for VisualDesignPatterns.DesignPatternHasConcreteClasses.ConcreteClass" Name="ConcreteClass" DisplayName="Concrete Class" PropertyName="DesignPattern" Multiplicity="One" PropagatesDelete="true" PropertyDisplayName="Design Pattern">
          <RolePlayer>
            <DomainClassMoniker Name="ConcreteClass" />
          </RolePlayer>
        </DomainRole>
      </Target>
    </DomainRelationship>
    <DomainRelationship Id="1490ba4c-54c2-4b9e-9596-8489aa048ca9" Description="Description for VisualDesignPatterns.ConcreteClassIsDerivedFromAbstractClasses" Name="ConcreteClassIsDerivedFromAbstractClasses" DisplayName="Concrete Class Is Derived From Abstract Classes" Namespace="VisualDesignPatterns">
      <Source>
        <DomainRole Id="d8cc524f-63d2-43fa-90e1-a78f434d90b8" Description="Description for VisualDesignPatterns.ConcreteClassIsDerivedFromAbstractClasses.ConcreteClass" Name="ConcreteClass" DisplayName="Concrete Class" PropertyName="AbstractClasses" PropertyDisplayName="Abstract Classes">
          <RolePlayer>
            <DomainClassMoniker Name="ConcreteClass" />
          </RolePlayer>
        </DomainRole>
      </Source>
      <Target>
        <DomainRole Id="64cec901-f6b2-464b-9726-0ccd2d21ef19" Description="Description for VisualDesignPatterns.ConcreteClassIsDerivedFromAbstractClasses.AbstractClass" Name="AbstractClass" DisplayName="Abstract Class" PropertyName="ConcreteClasses" PropertyDisplayName="Concrete Classes">
          <RolePlayer>
            <DomainClassMoniker Name="AbstractClass" />
          </RolePlayer>
        </DomainRole>
      </Target>
    </DomainRelationship>
    <DomainRelationship Id="f4689b98-b360-4307-ad56-f6be56552663" Description="Description for VisualDesignPatterns.ConcreteObjectIsImplementationOfConcreteClass" Name="ConcreteObjectIsImplementationOfConcreteClass" DisplayName="Concrete Object Is Implementation Of Concrete Class" Namespace="VisualDesignPatterns">
      <Source>
        <DomainRole Id="929feaa0-32d3-4eee-b866-862c8443546c" Description="Description for VisualDesignPatterns.ConcreteObjectIsImplementationOfConcreteClass.ConcreteObject" Name="ConcreteObject" DisplayName="Concrete Object" PropertyName="ConcreteClass" Multiplicity="One" PropertyDisplayName="Concrete Class">
          <RolePlayer>
            <DomainClassMoniker Name="ConcreteObject" />
          </RolePlayer>
        </DomainRole>
      </Source>
      <Target>
        <DomainRole Id="11f387fd-1aa7-4810-a83d-fd55e60e1869" Description="Description for VisualDesignPatterns.ConcreteObjectIsImplementationOfConcreteClass.ConcreteClass" Name="ConcreteClass" DisplayName="Concrete Class" PropertyName="ConcreteObjects" PropertyDisplayName="Concrete Objects">
          <RolePlayer>
            <DomainClassMoniker Name="ConcreteClass" />
          </RolePlayer>
        </DomainRole>
      </Target>
    </DomainRelationship>
  </Relationships>
  <Types>
    <ExternalType Name="DateTime" Namespace="System" />
    <ExternalType Name="String" Namespace="System" />
    <ExternalType Name="Int16" Namespace="System" />
    <ExternalType Name="Int32" Namespace="System" />
    <ExternalType Name="Int64" Namespace="System" />
    <ExternalType Name="UInt16" Namespace="System" />
    <ExternalType Name="UInt32" Namespace="System" />
    <ExternalType Name="UInt64" Namespace="System" />
    <ExternalType Name="SByte" Namespace="System" />
    <ExternalType Name="Byte" Namespace="System" />
    <ExternalType Name="Double" Namespace="System" />
    <ExternalType Name="Single" Namespace="System" />
    <ExternalType Name="Guid" Namespace="System" />
    <ExternalType Name="Boolean" Namespace="System" />
    <ExternalType Name="Char" Namespace="System" />
    <DomainEnumeration Name="PatternClassification" Namespace="VisualDesignPatterns" Description="Description for VisualDesignPatterns.PatternClassification">
      <Literals>
        <EnumerationLiteral Description="Description for VisualDesignPatterns.PatternClassification.Creational" Name="Creational" Value="" />
        <EnumerationLiteral Description="Description for VisualDesignPatterns.PatternClassification.Structural" Name="Structural" Value="" />
        <EnumerationLiteral Description="Description for VisualDesignPatterns.PatternClassification.Behavioral" Name="Behavioral" Value="" />
        <EnumerationLiteral Description="Description for VisualDesignPatterns.PatternClassification.Concurrency" Name="Concurrency" Value="" />
      </Literals>
    </DomainEnumeration>
  </Types>
  <Shapes>
    <GeometryShape Id="8b59d894-95a6-4188-b1c2-a1be437bd3d0" Description="Shape used to represent ExampleElements on a Diagram." Name="DesignPatternShape" DisplayName="Design Pattern Shape" Namespace="VisualDesignPatterns" FixedTooltipText="Design Pattern Shape" FillColor="224, 224, 224" OutlineColor="113, 111, 110" InitialWidth="2" InitialHeight="0.75" OutlineThickness="0.01" FillGradientMode="None" Geometry="Rectangle">
      <Notes>The shape has a text decorator used to display the Name property of the mapped ExampleElement.</Notes>
      <ShapeHasDecorators Position="Center" HorizontalOffset="0" VerticalOffset="0">
        <TextDecorator Name="NameDecorator" DisplayName="Name Decorator" DefaultText="NameDecorator" />
      </ShapeHasDecorators>
    </GeometryShape>
    <GeometryShape Id="8d73ce1a-eb3d-44d0-b768-5dce66771abf" Description="Description for VisualDesignPatterns.AbstractClassShape" Name="AbstractClassShape" DisplayName="Abstract Class Shape" Namespace="VisualDesignPatterns" FixedTooltipText="Abstract Class Shape" InitialHeight="1" Geometry="Rectangle" />
    <GeometryShape Id="768950ea-1d82-4a45-834e-39e6528796a1" Description="Description for VisualDesignPatterns.ConcreteClassShape" Name="ConcreteClassShape" DisplayName="Concrete Class Shape" Namespace="VisualDesignPatterns" FixedTooltipText="Concrete Class Shape" InitialHeight="1" Geometry="Rectangle" />
  </Shapes>
  <Connectors>
    <Connector Id="6a2a00cd-b755-41d5-b554-fe78511a312c" Description="Description for VisualDesignPatterns.InheritanceConnector" Name="InheritanceConnector" DisplayName="Inheritance Connector" Namespace="VisualDesignPatterns" FixedTooltipText="Inheritance Connector" />
  </Connectors>
  <XmlSerializationBehavior Name="DesiSerializationBehavior" Namespace="VisualDesignPatterns">
    <ClassData>
      <XmlClassData TypeName="Design" MonikerAttributeName="" SerializeId="true" MonikerElementName="designMoniker" ElementName="design" MonikerTypeName="DesignMoniker">
        <DomainClassMoniker Name="Design" />
        <ElementData>
          <XmlRelationshipData RoleElementName="designPatterns">
            <DomainRelationshipMoniker Name="DesignHasDesignPatterns" />
          </XmlRelationshipData>
          <XmlPropertyData XmlName="name">
            <DomainPropertyMoniker Name="Design/Name" />
          </XmlPropertyData>
        </ElementData>
      </XmlClassData>
      <XmlClassData TypeName="DesignPattern" MonikerAttributeName="name" SerializeId="true" MonikerElementName="designPatternMoniker" ElementName="designPattern" MonikerTypeName="DesignPatternMoniker">
        <DomainClassMoniker Name="DesignPattern" />
        <ElementData>
          <XmlPropertyData XmlName="name" IsMonikerKey="true">
            <DomainPropertyMoniker Name="DesignPattern/Name" />
          </XmlPropertyData>
          <XmlPropertyData XmlName="classification">
            <DomainPropertyMoniker Name="DesignPattern/Classification" />
          </XmlPropertyData>
          <XmlRelationshipData UseFullForm="true" RoleElementName="abstractClasses">
            <DomainRelationshipMoniker Name="DesignPatternHasAbstractClasses" />
          </XmlRelationshipData>
          <XmlRelationshipData UseFullForm="true" RoleElementName="concreteClasses">
            <DomainRelationshipMoniker Name="DesignPatternHasConcreteClasses" />
          </XmlRelationshipData>
        </ElementData>
      </XmlClassData>
      <XmlClassData TypeName="DesignHasDesignPatterns" MonikerAttributeName="" SerializeId="true" MonikerElementName="designHasDesignPatternsMoniker" ElementName="designHasDesignPatterns" MonikerTypeName="DesignHasDesignPatternsMoniker">
        <DomainRelationshipMoniker Name="DesignHasDesignPatterns" />
      </XmlClassData>
      <XmlClassData TypeName="DesignPatternShape" MonikerAttributeName="" SerializeId="true" MonikerElementName="designPatternShapeMoniker" ElementName="designPatternShape" MonikerTypeName="DesignPatternShapeMoniker">
        <GeometryShapeMoniker Name="DesignPatternShape" />
      </XmlClassData>
      <XmlClassData TypeName="DesiDiagram" MonikerAttributeName="" SerializeId="true" MonikerElementName="desiDiagramMoniker" ElementName="desiDiagram" MonikerTypeName="DesiDiagramMoniker">
        <DiagramMoniker Name="DesiDiagram" />
      </XmlClassData>
      <XmlClassData TypeName="AbstractClass" MonikerAttributeName="name" SerializeId="true" MonikerElementName="abstractClassMoniker" ElementName="abstractClass" MonikerTypeName="AbstractClassMoniker">
        <DomainClassMoniker Name="AbstractClass" />
        <ElementData>
          <XmlPropertyData XmlName="name" IsMonikerKey="true">
            <DomainPropertyMoniker Name="AbstractClass/Name" />
          </XmlPropertyData>
        </ElementData>
      </XmlClassData>
      <XmlClassData TypeName="ConcreteClass" MonikerAttributeName="" SerializeId="true" MonikerElementName="concreteClassMoniker" ElementName="concreteClass" MonikerTypeName="ConcreteClassMoniker">
        <DomainClassMoniker Name="ConcreteClass" />
        <ElementData>
          <XmlPropertyData XmlName="name">
            <DomainPropertyMoniker Name="ConcreteClass/Name" />
          </XmlPropertyData>
          <XmlRelationshipData UseFullForm="true" RoleElementName="abstractClasses">
            <DomainRelationshipMoniker Name="ConcreteClassIsDerivedFromAbstractClasses" />
          </XmlRelationshipData>
        </ElementData>
      </XmlClassData>
      <XmlClassData TypeName="DesignPatternHasAbstractClasses" MonikerAttributeName="" SerializeId="true" MonikerElementName="designPatternHasAbstractClassesMoniker" ElementName="designPatternHasAbstractClasses" MonikerTypeName="DesignPatternHasAbstractClassesMoniker">
        <DomainRelationshipMoniker Name="DesignPatternHasAbstractClasses" />
      </XmlClassData>
      <XmlClassData TypeName="DesignPatternHasConcreteClasses" MonikerAttributeName="" SerializeId="true" MonikerElementName="designPatternHasConcreteClassesMoniker" ElementName="designPatternHasConcreteClasses" MonikerTypeName="DesignPatternHasConcreteClassesMoniker">
        <DomainRelationshipMoniker Name="DesignPatternHasConcreteClasses" />
      </XmlClassData>
      <XmlClassData TypeName="AbstractClassShape" MonikerAttributeName="" SerializeId="true" MonikerElementName="abstractClassShapeMoniker" ElementName="abstractClassShape" MonikerTypeName="AbstractClassShapeMoniker">
        <GeometryShapeMoniker Name="AbstractClassShape" />
      </XmlClassData>
      <XmlClassData TypeName="ConcreteClassShape" MonikerAttributeName="" SerializeId="true" MonikerElementName="concreteClassShapeMoniker" ElementName="concreteClassShape" MonikerTypeName="ConcreteClassShapeMoniker">
        <GeometryShapeMoniker Name="ConcreteClassShape" />
      </XmlClassData>
      <XmlClassData TypeName="ConcreteClassIsDerivedFromAbstractClasses" MonikerAttributeName="" SerializeId="true" MonikerElementName="concreteClassIsDerivedFromAbstractClassesMoniker" ElementName="concreteClassIsDerivedFromAbstractClasses" MonikerTypeName="ConcreteClassIsDerivedFromAbstractClassesMoniker">
        <DomainRelationshipMoniker Name="ConcreteClassIsDerivedFromAbstractClasses" />
      </XmlClassData>
      <XmlClassData TypeName="InheritanceConnector" MonikerAttributeName="" SerializeId="true" MonikerElementName="inheritanceConnectorMoniker" ElementName="inheritanceConnector" MonikerTypeName="InheritanceConnectorMoniker">
        <ConnectorMoniker Name="InheritanceConnector" />
      </XmlClassData>
      <XmlClassData TypeName="ConcreteObject" MonikerAttributeName="" SerializeId="true" MonikerElementName="concreteObjectMoniker" ElementName="concreteObject" MonikerTypeName="ConcreteObjectMoniker">
        <DomainClassMoniker Name="ConcreteObject" />
        <ElementData>
          <XmlRelationshipData UseFullForm="true" RoleElementName="concreteClass">
            <DomainRelationshipMoniker Name="ConcreteObjectIsImplementationOfConcreteClass" />
          </XmlRelationshipData>
        </ElementData>
      </XmlClassData>
      <XmlClassData TypeName="ConcreteObjectIsImplementationOfConcreteClass" MonikerAttributeName="" SerializeId="true" MonikerElementName="concreteObjectIsImplementationOfConcreteClassMoniker" ElementName="concreteObjectIsImplementationOfConcreteClass" MonikerTypeName="ConcreteObjectIsImplementationOfConcreteClassMoniker">
        <DomainRelationshipMoniker Name="ConcreteObjectIsImplementationOfConcreteClass" />
      </XmlClassData>
    </ClassData>
  </XmlSerializationBehavior>
  <ExplorerBehavior Name="DesiExplorer" />
  <ConnectionBuilders>
    <ConnectionBuilder Name="ConcreteClassIsDerivedFromAbstractClassesBuilder">
      <LinkConnectDirective>
        <DomainRelationshipMoniker Name="ConcreteClassIsDerivedFromAbstractClasses" />
        <SourceDirectives>
          <RolePlayerConnectDirective>
            <AcceptingClass>
              <DomainClassMoniker Name="ConcreteClass" />
            </AcceptingClass>
          </RolePlayerConnectDirective>
        </SourceDirectives>
        <TargetDirectives>
          <RolePlayerConnectDirective>
            <AcceptingClass>
              <DomainClassMoniker Name="AbstractClass" />
            </AcceptingClass>
          </RolePlayerConnectDirective>
        </TargetDirectives>
      </LinkConnectDirective>
    </ConnectionBuilder>
    <ConnectionBuilder Name="ConcreteObjectIsImplementationOfConcreteClassBuilder">
      <LinkConnectDirective>
        <DomainRelationshipMoniker Name="ConcreteObjectIsImplementationOfConcreteClass" />
        <SourceDirectives>
          <RolePlayerConnectDirective>
            <AcceptingClass>
              <DomainClassMoniker Name="ConcreteObject" />
            </AcceptingClass>
          </RolePlayerConnectDirective>
        </SourceDirectives>
        <TargetDirectives>
          <RolePlayerConnectDirective>
            <AcceptingClass>
              <DomainClassMoniker Name="ConcreteClass" />
            </AcceptingClass>
          </RolePlayerConnectDirective>
        </TargetDirectives>
      </LinkConnectDirective>
    </ConnectionBuilder>
  </ConnectionBuilders>
  <Diagram Id="efa962b3-491d-4424-811c-fc56462e4837" Description="Description for VisualDesignPatterns.DesiDiagram" Name="DesiDiagram" DisplayName="Minimal Language Diagram" Namespace="VisualDesignPatterns">
    <Class>
      <DomainClassMoniker Name="Design" />
    </Class>
    <ShapeMaps>
      <ShapeMap>
        <DomainClassMoniker Name="DesignPattern" />
        <ParentElementPath>
          <DomainPath>DesignHasDesignPatterns.Design/!Design</DomainPath>
        </ParentElementPath>
        <DecoratorMap>
          <TextDecoratorMoniker Name="DesignPatternShape/NameDecorator" />
          <PropertyDisplayed>
            <PropertyPath>
              <DomainPropertyMoniker Name="DesignPattern/Name" />
            </PropertyPath>
          </PropertyDisplayed>
        </DecoratorMap>
        <GeometryShapeMoniker Name="DesignPatternShape" />
      </ShapeMap>
      <ShapeMap>
        <DomainClassMoniker Name="AbstractClass" />
        <ParentElementPath>
          <DomainPath>DesignPatternHasAbstractClasses.DesignPattern/!DesignPattern/DesignHasDesignPatterns.Design/!Design</DomainPath>
        </ParentElementPath>
        <GeometryShapeMoniker Name="AbstractClassShape" />
      </ShapeMap>
      <ShapeMap>
        <DomainClassMoniker Name="ConcreteClass" />
        <ParentElementPath>
          <DomainPath>DesignPatternHasConcreteClasses.DesignPattern/!DesignPattern/DesignHasDesignPatterns.Design/!Design</DomainPath>
        </ParentElementPath>
        <GeometryShapeMoniker Name="ConcreteClassShape" />
      </ShapeMap>
    </ShapeMaps>
  </Diagram>
  <Designer CopyPasteGeneration="CopyPasteOnly" FileExtension="des" EditorGuid="0686a5f8-13bc-4013-8312-645769111f2d">
    <RootClass>
      <DomainClassMoniker Name="Design" />
    </RootClass>
    <XmlSerializationDefinition CustomPostLoad="false">
      <XmlSerializationBehaviorMoniker Name="DesiSerializationBehavior" />
    </XmlSerializationDefinition>
    <ToolboxTab TabText="Desi">
      <ElementTool Name="DesignPattern" ToolboxIcon="resources\exampleshapetoolbitmap.bmp" Caption="Design Pattern" Tooltip="Create a Design Pattern" HelpKeyword="CreateExampleClassF1Keyword">
        <DomainClassMoniker Name="DesignPattern" />
      </ElementTool>
      <ElementTool Name="AbstractClass" ToolboxIcon="E:\Users\Shirish Goyal\Desktop\Projects\Visual-Design-Patterns\Visual Design Patterns\DslPackage\Resources\AbstractClass.bmp" Caption="Abstract Class" Tooltip="Abstract Class" HelpKeyword="AbstractClass">
        <DomainClassMoniker Name="AbstractClass" />
      </ElementTool>
      <ElementTool Name="ConcreteClass" ToolboxIcon="E:\Users\Shirish Goyal\Desktop\Projects\Visual-Design-Patterns\Visual Design Patterns\DslPackage\Resources\ConcreteClass.bmp" Caption="Concrete Class" Tooltip="Concrete Class" HelpKeyword="ConcreteClass">
        <DomainClassMoniker Name="ConcreteClass" />
      </ElementTool>
    </ToolboxTab>
    <Validation UsesMenu="false" UsesOpen="false" UsesSave="false" UsesLoad="false" />
    <DiagramMoniker Name="DesiDiagram" />
  </Designer>
  <Explorer ExplorerGuid="054ebb0c-fe10-47c1-92e0-2bc9d7916363" Title="Desi Explorer">
    <ExplorerBehaviorMoniker Name="Desi/DesiExplorer" />
  </Explorer>
</Dsl>