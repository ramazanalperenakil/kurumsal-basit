/**
 * @license Copyright (c) 2003-2020, CKSource - Frederico Knabben. All rights reserved.
 * For licensing, see https://ckeditor.com/legal/ckeditor-oss-license
 */
CKEDITOR.editorConfig = function( config ) {
  config.extraPlugins = 'wordcount,notification';
  config.toolbar [
  et cetera . . .
  ];

};

config.wordcount = {

    // Whether or not you want to show the Paragraphs Count
    showParagraphs: true,

    // Whether or not you want to show the Word Count
    showWordCount: true,

    // Whether or not you want to show the Char Count
    showCharCount: true,

    // Whether or not you want to count Spaces as Chars
    countSpacesAsChars: true,

    // Whether or not to include Html chars in the Char Count
    countHTML: true,
    
    // Maximum allowed Word Count, -1 is default for unlimited
    maxWordCount: 30,

    // Maximum allowed Char Count, -1 is default for unlimited
    maxCharCount: 30,

    // Add filter to add or remove element before counting (see CKEDITOR.htmlParser.filter), Default value : null (no filter)
    filter: new CKEDITOR.htmlParser.filter({
        elements: {
            div: function( element ) {
                if(element.attributes.class == 'mediaembed') {
                    return false;
                }
            }
        }
    })
};









