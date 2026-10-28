# TaxiPath

Free Open Source Taxi Briefing Tool for Microsoft Flight Simulator 2024

Create your route. Get briefed on each turn. Taxi confidently.

A free open-source tool to aid virtual pilots with taxi routes at airports using an interactive map and step-by-step briefings.

This aims to provide an easy to use lightweight tool for navigating around the ground.

TaxiPath will be a single application for Windows which integrates with MSFS 2024 using supported methods.

This project is currently in Early Development.

Features

✈️ Overview

Taxiing is a key part of any flight but can be confusing at some airports. TaxiPath aims to simplify this by allowing users to create their own taxi routes. These can be personalised with instructions and hold short notes. They can be viewed whilst flying.

This will be free to use and will be open source so the community can view, improve and contribute to the project.

🗺️ Features

Interactive Map

Upload an image of an airport chart you can use.

Zoom and pan around the airport.

Create taxi routes.

Add route points.

View your intended taxi route.

Future feature – Optionally align the map to the location.

Route Creator

Create bespoke taxi routes.

Add taxiway names, turns and instructions.

Add key points.

Add prominent hold short notes.

Save and edit multiple routes for the airport.

Step-by-step Briefing

Easy to read taxi instructions.

Use previous/next buttons to move around your briefing.

Hold short instructions highlighted.

Brief yourself before taxiing.

Friendly interface for use with the simulator.

MSFS 2024 Integration

Connect using SimConnect.

Show connection status.

Show aircraft position and heading.

Future feature – Show aircraft position on a calibrated map.

Manage if the simulator disconnects.

Local Storage

Save and load taxi briefings.

Store all airport information, route points and instructions.

Back-up your routes.

No need for an online account.

🛠️ Development Plan

TaxiPath will be developed in stages to ensure a solid base with some complex simulator integration.

Milestone / Version Features

Prototype Project setup, route store and local storage.

Basic Route Creator Chart upload, zoom, route points and route creation.

Briefing Step-by-step instructions, hold short points.

SimConnect Connection manager, live aircraft data.

Map Positioning Calibrated map, aircraft position.

Future Airport data integration, improved map support, optional route progression.

Only features that are actually created and tested will be considered complete. This may change depending on technical limitations and community feedback.

💻 Technologies

This project will be initially developed using:

C#/.NET – Application logic and simulator integration.

WPF – Desktop application.

SimConnect – Simulator integration.

JSON – Local storage for routes.

Git – Version control.

xUnit – Unit testing for core functionality.

Exact versions of the frameworks and SDKs will be listed as we develop.

📋 Requirements

This project will require:

Windows 10/11.

Microsoft Flight Simulator 2024.

Microsoft Flight Simulator 2024 SDK and SimConnect components.

The route creator will function without a connection to the simulator.

🚀 Installation

Once a tested version is released, downloadable versions will be available via the GitHub Releases section of the repository.

During development contributors will be able to clone the repository and open the solution in Visual Studio. You will need .NET desktop development components.

Instructions for building will be added once the project setup is available.

There is no guarantee that there will be a downloadable .exe until one has been built, tested and released.

🧪 Testing

This project will focus on making sure it is reliable. This will be achieved by developing in stages and testing in stages.

Testing will be done on:

Creating routes.

Editing routes.

Saving routes.

Instructions are in the correct order.

Route points are saved when restarting the application.

Chart and route files are missing/invalid.

SimConnect connects/disconnects.

Aircraft position is shown and map is calibrated.

Performance in long simulator sessions.

TaxiPath will only focus on reading data from the simulator. It won’t control aircraft movement and isn’t a replacement for any navigation or safety systems.

🤝 Contributions

Contributions, bug reports, suggestions and technical discussions are welcomed.

If you want to contribute:

Please check existing issues first.

Create an issue discussing any major features or changes to architecture.

Fork the repository and create a new branch.

Keep your changes simple and explain why.

Add/update any tests where possible.

Submit your changes as a pull request with a clear explanation.

Don’t submit any changes that haven’t been tested as this could cause issues with the route data, simulator and application.

🐛 Bug reports / Feature suggestions

When submitting a bug report, please include:

Explanation of the issue.

Steps to recreate the issue.

Version/commit of TaxiPath.

Version of Windows.

If using simulator integration, version of MSFS 2024.

Include relevant logs/images (remove any personal details).

When suggesting a new feature, please explain what the issue is and how the feature will help.

🔓 Open Source

This project will be free and open source.

The source code, documentation and original assets will be available on the repository using the licence set out in the LICENSE file.

A licence must be chosen and added before stating this is an open source project. Until then there are no licence terms.

Contributors should only submit code and assets they have the right to share. Airport charts, maps, logos and other external sources may have different licence terms.

⚠️ Disclaimer

TaxiPath is a tool to aid with flight simulation. It is not an air traffic control system and should not be used as a navigation system. Any routes entered by users may be incomplete, incorrect or out of date.

Always follow any instructions given by the ATC environment in the simulator. Be sensible with any simulated scenarios. Don’t assume that any routes shown are an actual ATC clearance.

This project is an independent community project and is not endorsed, sponsored or affiliated with Microsoft or Asobo Studio.

📌 Goals

Long term goals for this project are:

Make taxi briefing tools more accessible to the flight simulation community.

Provide an easy to use and lightweight tool.

Integrate with the simulator using well documented supported methods.

Encourage contributions from the community.

Free to use.

❤️ Thanks

Thanks to the Microsoft Flight Simulator SDK documentation, open source developers and flight simulation community for helping to make projects like this possible.

⸻

TaxiPath – Free and open source tools for the flight simulation community.