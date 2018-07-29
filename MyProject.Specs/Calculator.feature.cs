System.Configuration.ConfigurationErrorsException: The element <unitTestProvider> may only appear once in this section.
   at System.Configuration.ConfigurationElement.DeserializeElement(XmlReader reader, Boolean serializeCollectionKey)
   at System.Configuration.ConfigurationSection.DeserializeSection(XmlReader reader)
   at TechTalk.SpecFlow.Configuration.ConfigurationSectionHandler.CreateFromXml(String xmlContent)
   at TechTalk.SpecFlow.Configuration.ConfigurationLoader.Load(SpecFlowConfiguration specFlowConfiguration, ISpecFlowConfigurationHolder specFlowConfigurationHolder)
   at TechTalk.SpecFlow.Generator.Configuration.GeneratorConfigurationProvider.LoadConfiguration(SpecFlowConfiguration specFlowConfiguration, SpecFlowConfigurationHolder specFlowConfigurationHolder)
   at TechTalk.SpecFlow.Generator.GeneratorContainerBuilder.CreateContainer(SpecFlowConfigurationHolder configurationHolder, ProjectSettings projectSettings)
   at TechTalk.SpecFlow.Generator.TestGeneratorFactory.CreateGenerator(ProjectSettings projectSettings)
   at TechTalk.SpecFlow.VisualStudio.CodeBehindGenerator.Actions.GenerateTestFileAction.GenerateTestFile(GenerateTestFileParameters opts)

