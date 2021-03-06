# Hackathon Submission Entry form

> __Important__  
> 
> Copy and paste the content of this file into README.md or face automatic __disqualification__  
> All headlines and subheadlines shall be retained if not noted otherwise.  
> Fill in text in each section as instructed and then delete the existing text, including this blockquote.

You can find a very good reference to Github flavoured markdown reference in [this cheatsheet](https://github.com/adam-p/markdown-here/wiki/Markdown-Cheatsheet). If you want something a bit more WYSIWYG for editing then could use [StackEdit](https://stackedit.io/app) which provides a more user friendly interface for generating the Markdown code. Those of you who are [VS Code fans](https://code.visualstudio.com/docs/languages/markdown#_markdown-preview) can edit/preview directly in that interface too.

## Team name
⟹ Sitecore Frontliners

## Category
⟹ The best enhancement to SXA

## Description
⟹ Write a clear description of your hackathon entry.  

  - Module Purpose:
        - To replicate the site with an option to include the required items only and themes.
        - After replicating the site, it also allows user to clone certain items from one site (of one tenant) to another (of different tenant)
  
  - What problem was solved (if any)
    - It allows content author to replicate the site across different tenants with option to skip unwanted page items along with themes.

## Video link
⟹ Provide a video highlighing your Hackathon module submission and provide a link to the video. You can use any video hosting, file share or even upload the video to this repository. _Just remember to update the link below_

⟹ [Replace this Video link](#video-link)

## Pre-requisites and Dependencies

⟹ Does your module rely on other Sitecore modules or frameworks?

- List of dependencies:
    - SPE 6.2
    - SXA 10.1.0

## Installation instructions

1. Go to Sitecore 10.1 CM Evnironment
2. Login to Sitecore
3. Install attached sitecore package link here 
4. Access the utility from context menu option of Site item to replicate or clone the site or access any page item/datasource item context menu to replicate or clone item.

Sitecore Package Contents:
Package includes custom powershell scripts.

<img width="195" alt="2021-03-07 02_09_29-Desktop" src="https://user-images.githubusercontent.com/12103556/110222607-e5570880-7eec-11eb-93e1-516247e39b22.png">


## Usage instructions
⟹ Provide documentation about your module, how do the users use your module, where are things located, what do the icons mean, are there any secret shortcuts etc.
- Right click on any Site item which you want to replicate.

  <img width="471" alt="2021-03-07 01_48_36-Settings" src="https://user-images.githubusercontent.com/12103556/110222313-b9d31e80-7eea-11eb-8af4-fac89f1191d4.png">

- In custom replicate site dialog, you'll see fields like New Site Path - path where we want to create new site, Source site language, Target language, Copy theme or not etc.   Fill in the necessary information. 

  <img width="369" alt="2021-03-07 01_50_21-Desktop" src="https://user-images.githubusercontent.com/12103556/110222426-7a590200-7eeb-11eb-97e5-27c8f0e729ad.png">

- Go to next tab and select required modules for the new site

- Select items from source site which you want to replicate in new site. Other items won't be copied. You can also select if you want to copy item only or with children/descendants.

  <img width="370" alt="2021-03-07 01_58_47-Desktop" src="https://user-images.githubusercontent.com/12103556/110222455-c1df8e00-7eeb-11eb-9212-fcf3e645d01e.png">

- Site will be replicated and selected items will be copied to newly created site

  <img width="233" alt="2021-03-07 02_02_22-Desktop" src="https://user-images.githubusercontent.com/12103556/110222497-15ea7280-7eec-11eb-8458-d4b12b6a0de4.png">

- You can also copy any individual item with desired language version to newly created site if missed during site replication. Right click on any item which you want to copy, select Scripts -> Replicate Page

  <img width="496" alt="2021-03-07 02_03_46-Photos" src="https://user-images.githubusercontent.com/12103556/110222543-75e11900-7eec-11eb-948a-ee7b9692bf6d.png">

- Select source and target language for the item. Select destination path where you want to replicate the page and target item name if you want to specify different name then source otherwise leave empty.

  <img width="443" alt="2021-03-07 02_04_52-Desktop" src="https://user-images.githubusercontent.com/12103556/110222585-b50f6a00-7eec-11eb-833b-f60c2b9d7988.png">

- Newly replicated item will be visible in target location

  <img width="502" alt="2021-03-07 02_06_25-Desktop" src="https://user-images.githubusercontent.com/12103556/110222599-d2443880-7eec-11eb-945e-b580175aa5f1.png">
  

## Comments
If you'd like to make additional comments that is important for your module entry.
